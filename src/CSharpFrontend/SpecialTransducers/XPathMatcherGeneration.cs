using CodePlex.XPathParser;
using Microsoft.Automata;
using Microsoft.Automata.Z3;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.SpecialTransducers
{
    class XPathMatcherGeneration : TransducerCompilation
    {
        public override STb<FuncDecl, Expr, Sort> Transducer
        {
            get
            {
                if (_stb == null)
                {
                    _stb = Generate();
                }
                return _stb;
            }
        }

        public override IEnumerable<Tuple<FuncDecl, Expr, Expr[]>> FunctionBodies
        {
            get { return Enumerable.Empty<Tuple<FuncDecl, Expr, Expr[]>>(); }
        }

        public override ITypeSymbol InputTypeSymbol
        {
            get
            {
                return _charTypeSymbol;
            }
        }

        public override ITypeSymbol OutputTypeSymbol
        {
            get
            {
                switch (_type)
                {
                    case "int":
                    case "length":
                        return _intTypeSymbol;
                    case "bool":
                        return _boolTypeSymbol;
                    case "last":
                        return _charTypeSymbol;
                    default:
                        throw new TransducerCompilationException("Unrecognized ParsingMatcher parsing rule: " + _type);
                }
            }
        }

        Z3Provider _ctx;
        ITypeSymbol _charTypeSymbol;
        ITypeSymbol _intTypeSymbol;
        ITypeSymbol _boolTypeSymbol;
        string _xpath;
        string _type;
        STb<FuncDecl, Expr, Sort> _stb;

        public XPathMatcherGeneration(Z3Provider ctx, Compilation compilation, INamedTypeSymbol declarationType, AttributeSyntax typeAttribute)
            : base(declarationType)
        {
            _ctx = ctx;
            _charTypeSymbol = compilation.GetTypeByMetadataName(typeof(char).FullName);
            _intTypeSymbol = compilation.GetTypeByMetadataName(typeof(int).FullName);
            _boolTypeSymbol = compilation.GetTypeByMetadataName(typeof(bool).FullName);

            var arguments = typeAttribute.ArgumentList.Arguments;
            if (arguments.Count != 2)
            {
                throw new TransducerCompilationException("Unsupported XPathMatcher constructor encountered");
            }

            var regexSyntax = arguments[0].Expression as LiteralExpressionSyntax;
            if (regexSyntax == null || !(regexSyntax.Token.Value is string))
            {
                throw new TransducerCompilationException("First argument to XPathMatcher attribute must be a string literal");
            }
            _xpath = regexSyntax.Token.Value as string;

            var typeSyntax = arguments[1].Expression as LiteralExpressionSyntax;
            if (typeSyntax == null || !(typeSyntax.Token.Value is string))
            {
                throw new TransducerCompilationException("Second argument to XPathMatcher attribute must be a string literal");
            }
            _type = typeSyntax.Token.Value as string;

            if (_type != "int")
            {
                throw new TransducerCompilationException("XPathMatcher only supports extracting ints");
            }
        }

        struct IgnorerInfo
        {
            public IteRule<Expr> MoveToTagOpeningOrStandalone { get; set; }
            public BaseRule<Expr> MoveToTagOpening { get; set; }
            public BaseRule<Expr> MoveToOutsideTag { get; set; }
        }

        STb<FuncDecl, Expr, Sort> Generate()
        {
            var name = DeclarationType.ContainingNamespace.Name + "." +
                (DeclarationType.ContainingType == null ? "" : DeclarationType.ContainingType.Name + ".") + DeclarationType.Name;
            //Console.WriteLine("XPath " + name);

            var parser = new XPathParser<IXPathNode>();
            IXPathNode root;
            try
            {
                root = parser.Parse(_xpath, new XPathNodeBuilder());
                //Console.WriteLine(root);
            }
            catch (XPathParserException e)
            {
                throw new TransducerCompilationException("XPath parsing failed", e);
            }

            var resultSort = _ctx.MkBitVecSort(32);
            var levelCounterSort = _ctx.MkBitVecSort(32);
            var regSort = _ctx.MkTupleSort(resultSort, levelCounterSort);
            var initReg = _ctx.MkTuple(_ctx.MkNumeral(0, resultSort), _ctx.MkNumeral(0, levelCounterSort));

            var stb = new STb<FuncDecl, Expr, Sort>(_ctx, "stb", _ctx.CharSort, _ctx.MkBitVecSort(32), regSort, initReg, 0);
            int freeState = 1;
            Func<int> nextState = () => freeState++;

            var resultProj = _ctx.MkProj(0, stb.RegVar);
            var levelCounterProj = _ctx.MkProj(1, stb.RegVar);

            Func<int, IgnorerInfo> CreateIgnorer = (exitState) =>
            {
                IgnorerInfo info = new IgnorerInfo();

                int outsideTagState = nextState();
                int freshTagState = nextState();
                int openingTagState = nextState();
                int standaloneTagState = nextState();
                int closingTagState = nextState();

                stb.AssignRule(outsideTagState,
                    new IteRule<Expr>(EqualsChar(stb.InputVar, '<'),
                        new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, freshTagState),
                        new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, outsideTagState)));

                stb.AssignRule(freshTagState,
                    new IteRule<Expr>(EqualsChar(stb.InputVar, '/'),
                        new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, closingTagState),
                        new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, openingTagState)));

                var counterOne = _ctx.MkNumeral(1, levelCounterSort);
                var levelCounterInc = _ctx.MkTuple(resultProj, _ctx.MkBvAdd(levelCounterProj, counterOne));
                stb.AssignRule(openingTagState,
                    new IteRule<Expr>(EqualsChar(stb.InputVar, '>'),
                        new BaseRule<Expr>(Sequence<Expr>.Empty, levelCounterInc, outsideTagState),
                        new IteRule<Expr>(EqualsChar(stb.InputVar, '/'),
                            new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, standaloneTagState),
                            new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, openingTagState))));

                var counterZero = _ctx.MkNumeral(0, levelCounterSort);
                var levelCounterZeroed = _ctx.MkTuple(resultProj, counterZero);
                stb.AssignRule(standaloneTagState,
                    new IteRule<Expr>(EqualsChar(stb.InputVar, '>'),
                        new IteRule<Expr>(_ctx.MkEq(levelCounterProj, counterZero),
                            new BaseRule<Expr>(Sequence<Expr>.Empty, levelCounterZeroed, exitState),
                            new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, outsideTagState)),
                        new IteRule<Expr>(EqualsChar(stb.InputVar, '/'),
                            new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, standaloneTagState),
                            new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, openingTagState))));

                var levelCounterDec = _ctx.MkTuple(resultProj, _ctx.MkBvSub(levelCounterProj, counterOne));
                stb.AssignRule(closingTagState,
                    new IteRule<Expr>(EqualsChar(stb.InputVar, '>'),
                        new IteRule<Expr>(_ctx.MkEq(levelCounterProj, counterOne),
                            new BaseRule<Expr>(Sequence<Expr>.Empty, levelCounterZeroed, exitState),
                            new BaseRule<Expr>(Sequence<Expr>.Empty, levelCounterDec, outsideTagState)),
                        new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, closingTagState)));

                info.MoveToTagOpening = new BaseRule<Expr>(Sequence<Expr>.Empty, levelCounterZeroed, openingTagState);
                info.MoveToTagOpeningOrStandalone = new IteRule<Expr>(EqualsChar(stb.InputVar, '/'),
                            new BaseRule<Expr>(Sequence<Expr>.Empty, levelCounterZeroed, standaloneTagState),
                            info.MoveToTagOpening);
                var levelCounterSet = _ctx.MkTuple(resultProj, counterOne);
                info.MoveToOutsideTag = new BaseRule<Expr>(Sequence<Expr>.Empty, levelCounterSet, outsideTagState);

                return info;
            };

            var next = root;
            int? parentState = null;
            int startState = stb.InitialState;
            int childState = nextState();
            var zeroResult = _ctx.MkTuple(_ctx.MkNumeral(0, resultSort), levelCounterProj);
            while (next != null)
            {
                XPathAxisNode current;
                var step = next as XPathStepNode;
                if (step != null)
                {
                    current = step.Left as XPathAxisNode;
                    next = step.Right;
                }
                else
                {
                    current = next as XPathAxisNode;
                    next = null;
                }

                if (current.Axis == XPathAxis.Root) continue;

                if (current == null)
                    throw new TransducerCompilationException("Unsupported XPath node type: " + next.GetType());
                if (current.Axis != XPathAxis.Child)
                    throw new TransducerCompilationException("Unsupported axis: " + current.Axis);
                if (current.Type != System.Xml.XPath.XPathNodeType.Element)
                    throw new TransducerCompilationException("Unsupported node type: " + current.Type);

                int freshTagState = nextState();
                int closingTagState = nextState();
                int standaloneMatchState = nextState();
                int matchedOpeningTagState = nextState();
                int matchedStandaloneTagState = nextState();
                var ignorer = CreateIgnorer(startState);

                stb.AssignRule(startState,
                    new IteRule<Expr>(EqualsChar(stb.InputVar, '<'),
                        new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, freshTagState),
                        new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, startState)));

                int matchState = freshTagState;
                int nextMatchState = nextState();
                bool first = true;
                foreach (char c in current.Label)
                {
                    STbRule<Expr> matchRule;

                    if (first)
                    {
                        matchRule = new IteRule<Expr>(EqualsChar(stb.InputVar, '/'),
                            new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, closingTagState),
                            new IteRule<Expr>(EqualsChar(stb.InputVar, c),
                                new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, nextMatchState),
                                new IteRule<Expr>(EqualsChar(stb.InputVar, '>'),
                                    ignorer.MoveToOutsideTag,
                                    ignorer.MoveToTagOpening)));
                        first = false;
                    }
                    else
                    {
                        matchRule = new IteRule<Expr>(EqualsChar(stb.InputVar, c),
                            new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, nextMatchState),
                            new IteRule<Expr>(EqualsChar(stb.InputVar, '>'),
                                ignorer.MoveToOutsideTag,
                                ignorer.MoveToTagOpeningOrStandalone));
                    }

                    stb.AssignRule(matchState, matchRule);
                    matchState = nextMatchState;
                    nextMatchState = nextState();
                }

                stb.AssignRule(closingTagState,
                    new IteRule<Expr>(EqualsChar(stb.InputVar, '>'),
                        parentState != null ? (STbRule<Expr>)new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, parentState.Value) : new UndefRule<Expr>(),
                        new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, closingTagState)));

                stb.AssignRule(matchState,
                    new IteRule<Expr>(EqualsChar(stb.InputVar, '>'),
                        new BaseRule<Expr>(Sequence<Expr>.Empty, zeroResult, childState),
                        new IteRule<Expr>(EqualsChar(stb.InputVar, ' '),
                            new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, matchedOpeningTagState),
                                new IteRule<Expr>(EqualsChar(stb.InputVar, '/'),
                                    new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, standaloneMatchState),
                                    ignorer.MoveToTagOpening))));

                stb.AssignRule(standaloneMatchState,
                    new IteRule<Expr>(EqualsChar(stb.InputVar, '>'),
                        new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, startState),
                        new UndefRule<Expr>()));

                stb.AssignRule(matchedOpeningTagState,
                    new IteRule<Expr>(EqualsChar(stb.InputVar, '>'),
                        new BaseRule<Expr>(Sequence<Expr>.Empty, zeroResult, childState),
                        new IteRule<Expr>(EqualsChar(stb.InputVar, '/'),
                            new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, matchedStandaloneTagState),
                            new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, matchedOpeningTagState))));

                stb.AssignRule(matchedStandaloneTagState,
                    new IteRule<Expr>(EqualsChar(stb.InputVar, '>'),
                        new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, startState),
                        new IteRule<Expr>(EqualsChar(stb.InputVar, '/'),
                            new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, matchedStandaloneTagState),
                            new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, matchedOpeningTagState))));

                parentState = startState;
                startState = childState;
                childState = nextState();
            }

            Func<Expr, Expr> AddZeros = (c) =>
            {
                uint k = (uint)(32 - (int)_ctx.CharSetProvider.Encoding);
                if (k == 0)
                    return c;
                else
                    return _ctx.MkZeroExt(k, c);
            };
            var toIntUpdate = _ctx.MkTuple(
                _ctx.MkBvAdd(_ctx.MkBvMul(_ctx.MkNumeral(10, resultSort), resultProj), _ctx.MkBvSub(AddZeros(stb.InputVar), _ctx.MkNumeral((int)'0', resultSort))),
                levelCounterProj);

            var expectSlashState = nextState();
            var scanTagState = nextState();

            stb.AssignRule(startState,
                new IteRule<Expr>(EqualsChar(stb.InputVar, '<'),
                    new BaseRule<Expr>(new Sequence<Expr>(resultProj), zeroResult, expectSlashState),
                    new BaseRule<Expr>(Sequence<Expr>.Empty, toIntUpdate, startState)));

            stb.AssignRule(expectSlashState,
                new IteRule<Expr>(EqualsChar(stb.InputVar, '/'),
                    new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, scanTagState),
                    new UndefRule<Expr>()));

            stb.AssignRule(scanTagState,
                new IteRule<Expr>(EqualsChar(stb.InputVar, '>'),
                    parentState != null ? (STbRule<Expr>)new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, parentState.Value) : new UndefRule<Expr>(),
                    new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, scanTagState)));

            Console.WriteLine(stb.StateCount);

            foreach (var state in stb.States)
            {
                stb.AssignFinalRule(state, new BaseRule<Expr>(Sequence<Expr>.Empty, stb.RegVar, state));
            }
            
            if (ShowGraphStages.Count > 0) { stb.ToST().ShowGraph(); }
            return stb;
        }

        Expr EqualsChar(Expr expr, char c)
        {
            return _ctx.MkEq(expr, _ctx.MkNumeral(c, expr.Sort));
        }
    }
}
