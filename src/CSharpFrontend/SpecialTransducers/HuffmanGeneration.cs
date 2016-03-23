using Microsoft.Automata;
using Microsoft.Automata.Z3;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.SpecialTransducers
{
    abstract class HuffmanNode : IComparable<HuffmanNode>
    {
        public double Probability { get; set; }
        public int Size { get; set; }

        public abstract int CompareTo(HuffmanNode other);
    }

    class HuffmanDecision : HuffmanNode
    {
        public HuffmanNode Left { get; set; }
        public HuffmanNode Right { get; set; }

        public override int CompareTo(HuffmanNode other)
        {
            var probComp = Probability.CompareTo(other.Probability);
            if (probComp != 0)
            {
                return probComp;
            }
            // Use size as tiebreaker to ensure a more balanced tree when probabilities match
            var sizeComp = Size.CompareTo(other.Size);
            if (sizeComp != 0)
            {
                return sizeComp;
            }
            var casted = other as HuffmanDecision;
            if (casted == null)
            {
                return 1;
            }
            var leftComp = Left.CompareTo(casted.Left);
            if (leftComp != 0)
            {
                return leftComp;
            }
            return Right.CompareTo(casted.Right);
        }
    }

    class HuffmanLeaf : HuffmanNode
    {
        public byte Symbol { get; set; }

        public override int CompareTo(HuffmanNode other)
        {
            var probComp = Probability.CompareTo(other.Probability);
            if (probComp != 0)
            {
                return probComp;
            }
            // Use size as tiebreaker to ensure a more balanced tree when probabilities match
            var sizeComp = Size.CompareTo(other.Size);
            if (sizeComp != 0)
            {
                return sizeComp;
            }
            var casted = other as HuffmanLeaf;
            if (casted == null)
            {
                return -1;
            }
            return Symbol.CompareTo(casted.Symbol);
        }
    }

    class HuffmanGeneration : TransducerCompilation
    {
        public override STb<FuncDecl, Expr, Sort> Transducer
        {
            get
            {
                if (_stb == null)
                {
                    _stb = _isDecoder ? GenerateDecoder() : GenerateEncoder();
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
            get { return _isDecoder ? _boolTypeSymbol : _byteTypeSymbol; }
        }

        public override ITypeSymbol OutputTypeSymbol
        {
            get { return _byteTypeSymbol; }
        }

        Z3Provider _automataCtx;
        ITypeSymbol _boolTypeSymbol;
        ITypeSymbol _byteTypeSymbol;
        bool _isDecoder;
        HuffmanNode _tree;
        STb<FuncDecl, Expr, Sort> _stb;

        public HuffmanGeneration(Z3Provider ctx, Compilation compilation, INamedTypeSymbol declarationType, AttributeSyntax typeAttribute, bool isDecoder)
            : base(declarationType)
        {
            _automataCtx = ctx;
            _boolTypeSymbol = compilation.GetTypeByMetadataName(typeof(bool).FullName);
            _byteTypeSymbol = compilation.GetTypeByMetadataName(typeof(byte).FullName);
            _isDecoder = isDecoder;

            var arguments = typeAttribute.ArgumentList.Arguments;
            if (arguments.Count != 1)
            {
                throw new TransducerCompilationException("Unsupported HuffmanDecoder/Encoder constructor encountered");
            }

            var fileNameSyntax = arguments[0].Expression as LiteralExpressionSyntax;
            if (fileNameSyntax == null || !(fileNameSyntax.Token.Value is string))
            {
                throw new TransducerCompilationException("Argument to HuffmanDecoder/Encoder attribute must be a string literal");
            }
            var fileName = fileNameSyntax.Token.Value as string;
            var bytes = File.ReadAllBytes(fileName);
            _tree = CreateTree(bytes);
        }

        HuffmanNode CreateTree(byte[] exampleBytes)
        {
            var probabilities = new double[256];
            foreach (var symbol in exampleBytes)
            {
                ++probabilities[symbol];
            }
            for (int i = 0; i < probabilities.Length; ++i)
            {
                probabilities[i] /= exampleBytes.Length;
            }

            var unmerged = new SortedSet<HuffmanNode>();
            for (int i = 0; i < probabilities.Length; ++i)
            {
                unmerged.Add(new HuffmanLeaf
                {
                    Probability = probabilities[i],
                    Size = 1,
                    Symbol = (byte)i
                });
            }
            while (true)
            {
                var right = unmerged.First();
                unmerged.Remove(right);
                if (unmerged.Count == 0)
                {
                    return right;
                }
                var left = unmerged.First();
                unmerged.Remove(left);
                unmerged.Add(new HuffmanDecision
                {
                    Probability = left.Probability + right.Probability,
                    Size = left.Size + right.Size,
                    Left = left,
                    Right = right
                });
            }
        }

        STb<FuncDecl, Expr, Sort> GenerateToBooleans()
        {
            var ctx = _automataCtx.Z3;

            Expr inputVar = ctx.MkBound(0, ctx.MkBitVecSort(8));
            Expr registerVar = ctx.MkBound(1, _automataCtx.MkTupleSort());
            Sort outputSort = ctx.BoolSort;
            var stb = new STb<FuncDecl, Expr, Sort>(_automataCtx, DeclarationType.Name, inputVar.Sort, outputSort, registerVar.Sort, _automataCtx.MkTuple(), 0);

            var bitExprs = new Expr[8];
            for (uint i = 0; i < bitExprs.Length; ++i)
            {
                bitExprs[i] = ctx.MkEq(ctx.MkExtract(i, i, (BitVecExpr)inputVar), ctx.MkBV(1, 1));
            }
            stb.AssignRule(0, new BaseRule<Expr>(new Sequence<Expr>(bitExprs), registerVar, 0));
            stb.AssignFinalRule(0, new BaseRule<Expr>(Sequence<Expr>.Empty, registerVar, 0));
            return stb;
        }

        void PreOrder(HuffmanNode node, Action<HuffmanNode> action)
        {
            action(node);
            var decision = node as HuffmanDecision;
            if (decision != null)
            {
                PreOrder(decision.Left, action);
                PreOrder(decision.Right, action);
            }
        }

        STb<FuncDecl, Expr, Sort> GenerateDecoder()
        {
            var ctx = _automataCtx.Z3;

            Expr inputVar = ctx.MkBound(0, ctx.BoolSort);
            Expr registerVar = ctx.MkBound(1, _automataCtx.MkTupleSort());
            Sort outputSort = ctx.MkBitVecSort(8);
            var stb = new STb<FuncDecl, Expr, Sort>(_automataCtx, DeclarationType.Name, inputVar.Sort, outputSort, registerVar.Sort, _automataCtx.MkTuple(), 0);

            int nextState = 0;
            var states = new Dictionary<HuffmanDecision, int>();
            PreOrder(_tree, node =>
            {
                var decision = node as HuffmanDecision;
                if (decision != null)
                {
                    states.Add(decision, nextState++);
                }
            });
            Func<HuffmanNode, BaseRule<Expr>> getBaseRule = node =>
            {
                var decision = node as HuffmanDecision;
                if (decision != null)
                {
                    return new BaseRule<Expr>(Sequence<Expr>.Empty, registerVar, states[decision]);
                }
                else
                {
                    var leaf = (HuffmanLeaf)node;
                    return new BaseRule<Expr>(new Sequence<Expr>(ctx.MkBV(leaf.Symbol, 8)), registerVar, 0);
                }
            };
            PreOrder(_tree, node =>
            {
                var decision = node as HuffmanDecision;
                if (decision != null)
                {
                    stb.AssignRule(states[decision], new IteRule<Expr>(inputVar, getBaseRule(decision.Left), getBaseRule(decision.Right)));
                    stb.AssignFinalRule(states[decision], new BaseRule<Expr>(Sequence<Expr>.Empty, registerVar, states[decision]));
                }
            });

            if (ShowGraphStages.Count > 0) { stb.ToST().ShowGraph(); }
            return stb;
        }

        STb<FuncDecl, Expr, Sort> GenerateToBytes()
        {
            var ctx = _automataCtx.Z3;

            Expr inputVar = ctx.MkBound(0, ctx.BoolSort);
            Expr registerVar = ctx.MkBound(1, _automataCtx.MkTupleSort(ctx.MkBitVecSort(8), ctx.MkBitVecSort(32)));
            Sort outputSort = ctx.MkBitVecSort(8);
            Expr initialRegister = _automataCtx.MkTuple(ctx.MkBV(0, 8), ctx.MkBV(0, 32));
            var stb = new STb<FuncDecl, Expr, Sort>(_automataCtx, DeclarationType.Name, inputVar.Sort, outputSort, registerVar.Sort, initialRegister, 0);

            BitVecExpr symbolProj = (BitVecExpr)_automataCtx.MkProj(0, registerVar);
            BitVecExpr counterProj = (BitVecExpr)_automataCtx.MkProj(1, registerVar);

            var withFalse = ctx.MkBVLSHR(symbolProj, ctx.MkBV(1, 8));
            var withTrue = ctx.MkBVOR(withFalse, ctx.MkBV(0x80, 8));
            var counterIncremented = ctx.MkBVAdd(counterProj, ctx.MkBV(1, 32));

            var accumulateTrue = new BaseRule<Expr>(Sequence<Expr>.Empty, _automataCtx.MkTuple(withTrue, counterIncremented), 0);
            var accumulateFalse = new BaseRule<Expr>(Sequence<Expr>.Empty, _automataCtx.MkTuple(withFalse, counterIncremented), 0);
            var accumulate = new IteRule<Expr>(inputVar, accumulateTrue, accumulateFalse);

            var yieldTrueAndReset = new BaseRule<Expr>(new Sequence<Expr>(withTrue), initialRegister, 0);
            var yieldFalseAndReset = new BaseRule<Expr>(new Sequence<Expr>(withFalse), initialRegister, 0);
            var yieldAndReset = new IteRule<Expr>(inputVar, yieldTrueAndReset, yieldFalseAndReset);

            var move = new IteRule<Expr>(ctx.MkBVULT(counterProj, ctx.MkBV(7, 32)), accumulate, yieldAndReset);
            stb.AssignRule(0, move);

            STbRule<Expr> final = new BaseRule<Expr>(Sequence<Expr>.Empty, registerVar, 0);
            for (int i = 1; i <= 7; ++i)
            {
                var yieldRule = new BaseRule<Expr>(new Sequence<Expr>(ctx.MkBVLSHR(symbolProj, ctx.MkBV(8 - i, 8))), registerVar, 0);
                final = new IteRule<Expr>(ctx.MkEq(counterProj, ctx.MkBV(i, 32)), yieldRule, final);
            }
            stb.AssignFinalRule(0, final);
            return stb;
        }

        STb<FuncDecl, Expr, Sort> GenerateEncoder()
        {
            var ctx = _automataCtx.Z3;

            Expr inputVar = ctx.MkBound(0, ctx.MkBitVecSort(8));
            Expr registerVar = ctx.MkBound(1, _automataCtx.MkTupleSort());
            Sort outputSort = ctx.BoolSort;
            var stb = new STb<FuncDecl, Expr, Sort>(_automataCtx, DeclarationType.Name, inputVar.Sort, outputSort, registerVar.Sort, _automataCtx.MkTuple(), 0);

            var leafPatterns = new Dictionary<byte, bool[]>();
            FindLeafPatterns(leafPatterns, _tree, new Stack<bool>());

            var patterns = new bool[256][];
            foreach (var entry in leafPatterns)
            {
                patterns[entry.Key] = entry.Value;
            }
            Debug.Assert(patterns.Select((x, i) => patterns.Select((y, j) => i == j || x.Length != y.Length || x.Zip(y, (a, b) => Tuple.Create(a, b)).Any(z => z.Item1 != z.Item2)).All(z => z)).All(z => z));
            Debug.Assert(patterns.All(x => x != null), "Internal Huffman tree is missing leaves");

            stb.AssignRule(0, GetBinarySearchRule(ctx, (BitVecExpr)inputVar, registerVar, patterns, 0, patterns.Length));
            stb.AssignFinalRule(0, new BaseRule<Expr>(Sequence<Expr>.Empty, registerVar, 0));

            stb = stb.Compose(GenerateToBytes());
            stb = stb.ExploreBools();
            if (ShowGraphStages.Count > 0) { stb.ToST().ShowGraph(); }
            return stb;
        }

        void FindLeafPatterns(Dictionary<byte, bool[]> leafPatterns, HuffmanNode node, Stack<bool> currentPattern)
        {
            var decision = node as HuffmanDecision;
            if (decision != null)
            {
                currentPattern.Push(true);
                FindLeafPatterns(leafPatterns, decision.Left, currentPattern);
                currentPattern.Pop();
                currentPattern.Push(false);
                FindLeafPatterns(leafPatterns, decision.Right, currentPattern);
                currentPattern.Pop();
            }
            else
            {
                var leaf = (HuffmanLeaf)node;
                leafPatterns.Add(leaf.Symbol, currentPattern.ToArray());
            }
        }

        STbRule<Expr> GetBinarySearchRule(Context ctx, BitVecExpr inputVar, Expr registerVar, bool[][] patterns, int begin, int end)
        {
            if (begin + 1 == end)
            {
                return new BaseRule<Expr>(BoolYields(ctx, patterns[begin]), registerVar, 0);
            }

            int middle = begin + (end - begin) / 2;
            return new IteRule<Expr>(ctx.MkBVULT(inputVar, ctx.MkBV(middle, 8)),
                GetBinarySearchRule(ctx, inputVar, registerVar, patterns, begin, middle),
                GetBinarySearchRule(ctx, inputVar, registerVar, patterns, middle, end));
        }

        Sequence<Expr> BoolYields(Context ctx, bool[] bools)
        {
            return new Sequence<Expr>(bools.Select(x => ctx.MkBool(x)));
        }
    }
}
