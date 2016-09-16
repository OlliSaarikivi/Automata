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
    class ParsingMatcherGeneration : TransducerCompilation
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

        Z3Provider _automataCtx;
        ITypeSymbol _charTypeSymbol;
        ITypeSymbol _intTypeSymbol;
        ITypeSymbol _boolTypeSymbol;
        string _regex;
        string _type;
        STb<FuncDecl, Expr, Sort> _stb;

        public ParsingMatcherGeneration(Z3Provider ctx, Compilation compilation, INamedTypeSymbol declarationType, AttributeSyntax typeAttribute)
            : base(declarationType)
        {
            _automataCtx = ctx;
            _charTypeSymbol = compilation.GetTypeByMetadataName(typeof(char).FullName);
            _intTypeSymbol = compilation.GetTypeByMetadataName(typeof(int).FullName);
            _boolTypeSymbol = compilation.GetTypeByMetadataName(typeof(bool).FullName);

            var arguments = typeAttribute.ArgumentList.Arguments;
            if (arguments.Count != 2)
            {
                throw new TransducerCompilationException("Unsupported ParsingMatcher constructor encountered");
            }

            var regexSyntax = arguments[0].Expression as LiteralExpressionSyntax;
            if (regexSyntax == null || !(regexSyntax.Token.Value is string))
            {
                throw new TransducerCompilationException("First argument to ParsingMatcher attribute must be a string literal");
            }
            _regex = regexSyntax.Token.Value as string;

            var typeSyntax = arguments[1].Expression as LiteralExpressionSyntax;
            if (typeSyntax == null || !(typeSyntax.Token.Value is string))
            {
                throw new TransducerCompilationException("Second argument to ParsingMatcher attribute must be a string literal");
            }
            _type = typeSyntax.Token.Value as string;
        }

        STb<FuncDecl, Expr, Sort> Generate()
        {
            var name = DeclarationType.ContainingNamespace.Name + "." +
                (DeclarationType.ContainingType == null ? "" : DeclarationType.ContainingType.Name + ".") + DeclarationType.Name;
            //Console.WriteLine("Regex " + name);

            var builder = new STbFromRegexBuilder<FuncDecl, Expr, Sort>(_automataCtx);
            var stb = builder.Mk(_regex, "value", _type);

            if ((stb.OutputSort is TupleSort || _automataCtx.IsTupleSort(stb.OutputSort)) && _automataCtx.GetTupleConstructor(stb.OutputSort).Arity == 1)
            {
                var fieldDecl = _automataCtx.GetTupleField(stb.OutputSort, 0);
                var reg = _automataCtx.MkTuple();
                var projector = new STb<FuncDecl, Expr, Sort>(_automataCtx, "Project", stb.OutputSort, fieldDecl.Range, reg.Sort, reg, 0);
                projector.AssignRule(0, new BaseRule<Expr>(new Sequence<Expr>(fieldDecl.Apply(projector.InputVar)), reg, 0));
                projector.AssignFinalRule(0, new BaseRule<Expr>(Sequence<Expr>.Empty, reg, 0));
                stb = stb.Compose(projector).Flatten();
            }

            if (ShowGraphStages.Count > 0) { stb.ToST().ShowGraph(); }
            return stb;
        }
    }
}
