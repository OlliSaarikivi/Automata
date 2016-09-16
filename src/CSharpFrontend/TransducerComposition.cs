using Microsoft.Automata;
using Microsoft.CodeAnalysis;
using Microsoft.Automata.CSharpFrontend.Runtime.Transducer;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend
{
    class TransducerComposition : TransducerCompilation
    {
        int _minimizeRemoved;
        int _simplifyRemoved;

        public int MinimizeRemoved
        {
            get
            {
                int sum = _minimizeRemoved;
                if (_inner is TransducerComposition)
                {
                    sum += (_inner as TransducerComposition).MinimizeRemoved;
                }
                if (_outer is TransducerComposition)
                {
                    sum += (_outer as TransducerComposition).MinimizeRemoved;
                }
                return sum;
            }
        }

        public int SimplifyRemoved
        {
            get
            {
                int sum = _simplifyRemoved;
                if (_inner is TransducerComposition)
                {
                    sum += (_inner as TransducerComposition).SimplifyRemoved;
                }
                if (_outer is TransducerComposition)
                {
                    sum += (_outer as TransducerComposition).SimplifyRemoved;
                }
                return sum;
            }
        }

        public override STb<FuncDecl, Expr, Sort> Transducer
        {
            get
            {
                if (_transducer == null)
                {
                    _transducer = Compose();
                }
                return _transducer;
            }
        }
        STb<FuncDecl, Expr, Sort> _transducer;

        public override IEnumerable<Tuple<FuncDecl, Expr, Expr[]>> FunctionBodies
        {
            get { return _inner.FunctionBodies.Concat(_outer.FunctionBodies); }
        }

        public override ITypeSymbol InputTypeSymbol
        {
            get { return _inner.InputTypeSymbol; }
        }

        public override ITypeSymbol OutputTypeSymbol
        {
            get { return _outer.OutputTypeSymbol; }
        }

        public TransducerCompilation _inner, _outer;

        public TransducerComposition(INamedTypeSymbol declarationType)
            : base(declarationType)
        {
        }

        public void SetOperands(TransducerCompilation inner, TransducerCompilation outer)
        {
            _inner = inner;
            _outer = outer;
        }

        public STb<FuncDecl, Expr, Sort> Compose(int K = 3, bool benchmarkK = false)
        {
            _minimizeRemoved = 0;
            _simplifyRemoved = 0;
            if (benchmarkK)
            {
                if (_inner is TransducerComposition)
                {
                    var t = _inner as TransducerComposition;
                    t._transducer = t.Compose(K, benchmarkK);
                }
                if (_outer is TransducerComposition)
                {
                    var t = _outer as TransducerComposition;
                    t._transducer = t.Compose(K, benchmarkK);
                }
            }
            var inner = _inner.Transducer;
            var outer = _outer.Transducer;

            if (!benchmarkK)
            {
                var innerName = _inner.DeclarationType.ContainingNamespace.Name + "." +
                (_inner.DeclarationType.ContainingType == null ? "" : _inner.DeclarationType.ContainingType.Name + ".") + _inner.DeclarationType.Name;
                var outerName = _outer.DeclarationType.ContainingNamespace.Name + "." +
                    (_outer.DeclarationType.ContainingType == null ? "" : _outer.DeclarationType.ContainingType.Name + ".") + _outer.DeclarationType.Name;
                //Console.WriteLine("Composing " + innerName + " with " + outerName);
            }
            
            var stb = inner.Compose(outer);
            var stb1 = stb;
            if (ShowGraphStages.Contains(ShowGraph.Stage.UnSimplified)) { stb.ToST().ShowGraph(); }
            if (UseMinimization)
            {
                stb1 = stb.Minimize();
                _minimizeRemoved += StatesRemoved(stb, stb1);
            }
            stb = stb1;
            var k = (K < 0 ? (stb.StateCount == 1 ? 2 : stb.StateCount) : K);
            stb1 = stb.Simplify(K);
            _simplifyRemoved += TotalIteRules(stb) - TotalIteRules(stb1);
            stb = stb1;
            stb = stb.Flatten();
            if (UseMinimization)
            {
                stb1 = stb.Minimize();
                _minimizeRemoved += StatesRemoved(stb, stb1);
            }
            stb = stb1;
            if (ShowGraphStages.Contains(ShowGraph.Stage.Simplified)) { stb.ToST().ShowGraph(); }

            Console.WriteLine(DeclarationType.Name + ": K=" + k + " Min=" + MinimizeRemoved + " Simp=" + SimplifyRemoved + " TotalCS=" + stb.StateCount + " TotalITE=" + TotalIteRules(stb));

            return stb;
        }

        int StatesRemoved(STb<FuncDecl, Expr, Sort> from, STb<FuncDecl, Expr, Sort> to)
        {
            return from.StateCount - to.StateCount;
        }

        int TotalIteRules(STb<FuncDecl, Expr, Sort> stb)
        {
            int count = 0;
            foreach (var state in stb.States)
            {
                var rule = stb.GetRuleFrom(state);
                count += IteRules(rule);
            }
            return count;
        }

        int IteRules(STbRule<Expr> rule)
        {
            switch (rule.RuleKind)
            {
                case STbRuleKind.Ite:
                    return 1 + IteRules(rule.TrueCase) + IteRules(rule.FalseCase);
                case STbRuleKind.Switch:
                    throw new Exception("Switch rules are not supported");
                default:
                    return 0;
            }
        }
    }
}
