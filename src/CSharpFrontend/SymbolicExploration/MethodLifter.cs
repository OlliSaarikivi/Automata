using Microsoft.CodeAnalysis;
using Microsoft.Automata.CSharpFrontend.SymbolicExploration.Mutators;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.SymbolicExploration
{
    /// <summary>
    /// Lifts C# methods into methods on <see cref="Mutator"/> instances. The methods are mapped to Z3 function which are used to create updated mutator values.
    /// </summary>
    class MethodLifter
    {
        Context Ctx { get { return _info.Ctx; } }
        TypeSymbolToSortMapper Mapper { get { return _info.Mapper; } }

        CompilationInfo _info;
        // Instance methods return a tuple of the mutated instance and the return value
        Dictionary<IMethodSymbol, Func<Mutator, Tuple<Mutator, Mutator>>> _instance0 = new Dictionary<IMethodSymbol, Func<Mutator, Tuple<Mutator, Mutator>>>();
        Dictionary<IMethodSymbol, Func<Mutator, Mutator>> _static1 = new Dictionary<IMethodSymbol, Func<Mutator, Mutator>>();
        Dictionary<IMethodSymbol, Func<Mutator, Mutator, Mutator>> _static2 = new Dictionary<IMethodSymbol, Func<Mutator, Mutator, Mutator>>();

        public MethodLifter(CompilationInfo info)
        {
            _info = info;
        }

        #region T1 ()
        public Func<Mutator, Tuple<Mutator, Mutator>> LiftInstanceNonVoidNullaryMethod(IMethodSymbol method)
        {
            Contract.Requires(!method.IsStatic);
            Contract.Requires(!method.ReturnsVoid);
            Contract.Requires(method.Arity == 0);

            return _instance0.GetOrCreate(method, () =>
            {
                if (Mapper.IsIntBuiltin(method.ContainingType))
                {
                    return LiftIntBuiltinInstanceVoidNullaryMethod(method);
                }
                throw new SymbolicExplorationException("No lifted counterpart found for " + method);
            });
        }

        Func<Mutator, Tuple<Mutator, Mutator>> LiftIntBuiltinInstanceVoidNullaryMethod(IMethodSymbol method)
        {
            // Ugly hack: use Int instead of the correct bitvector sort
            //var thisMapping = Mapper.GetBitVecSortMapping(method.ReceiverType);
            //Func<ArithExpr, ArithExpr> z3Constructor = null;
            //switch (method.Name)
            //{
            //    case "op_Increment":
            //        z3Constructor = x => Ctx.MkAdd(x, Ctx.MkInt(1));
            //        break;
            //    case "op_Decrement":
            //        z3Constructor = x => Ctx.MkSub(x, Ctx.MkInt(1));
            //        break;
            //}

            // Here is the correct thing to do

            var thisMapping = Mapper.GetBitVecSortMapping(method.ReceiverType);
            Func<BitVecExpr, BitVecExpr> z3Constructor = null;
            switch (method.Name)
            {
                case "op_Increment":
                    z3Constructor = x => Ctx.MkBVAdd(x, Ctx.MkBV(1, thisMapping.Sort.Size));
                    break;
                case "op_Decrement":
                    z3Constructor = x => Ctx.MkBVSub(x, Ctx.MkBV(1, thisMapping.Sort.Size));
                    break;
            }
            if (z3Constructor != null)
            {
                return op =>
                {
                    var newValue = LiftZ3Op1(z3Constructor, thisMapping.MutatorForValue, thisMapping)(op);
                    return Tuple.Create(newValue, newValue);
                };
            }
            throw new SymbolicExplorationException("No lifted counterpart found for " + method);
        }
        #endregion

        #region static T1 (T2)
        public Func<Mutator, Mutator> LiftStaticNonVoidUnaryMethod(IMethodSymbol method)
        {
            Contract.Requires(method.IsStatic);
            Contract.Requires(!method.ReturnsVoid);
            Contract.Requires(method.Arity == 1);

            return _static1.GetOrCreate(method, () =>
            {
                if (Mapper.IsIntBuiltin(method.ContainingType))
                {
                    return LiftIntBuiltinStaticNonVoidUnaryMethod(method);
                }
                if (method.ContainingType.SpecialType == SpecialType.System_Boolean)
                {
                    return LiftBoolBuiltinStaticNonVoidUnaryMethod(method);
                }
                throw new SymbolicExplorationException("No lifted counterpart found for " + method);
            });
        }

        Func<Mutator, Mutator> LiftIntBuiltinStaticNonVoidUnaryMethod(IMethodSymbol method)
        {
            if (Mapper.IsIntBuiltin(method.ReturnType)
                && method.ReturnType == method.Parameters[0].Type)
            {
                // Ugly hack: use Int instead of the correct bitvector sort
                //var returnMapping = Mapper.BigIntSortMapping;
                //Func<ArithExpr, ArithExpr> z3Constructor = null;
                //switch (method.Name)
                //{
                //    case "op_UnaryPlus":
                //        z3Constructor = x => x;
                //        break;
                //    case "op_UnaryNegation":
                //        z3Constructor = Ctx.MkUnaryMinus;
                //        break;
                //}

                // Here is the correct thing to do

                var returnMapping = Mapper.GetBitVecSortMapping(method.ReturnType);
                Func<BitVecExpr, BitVecExpr> z3Constructor = null;
                switch (method.Name)
                {
                    case "op_UnaryPlus":
                        z3Constructor = x => x;
                        break;
                    case "op_UnaryNegation":
                        z3Constructor = Ctx.MkBVNeg;
                        break;
                    case "op_OnesComplement":
                        z3Constructor = Ctx.MkBVNot;
                        break;
                }
                if (z3Constructor != null)
                {
                    return LiftZ3Op1(z3Constructor, returnMapping.MutatorForValue, returnMapping);
                }
            }
            throw new SymbolicExplorationException("No lifted counterpart found for " + method);
        }

        Func<Mutator, Mutator> LiftBoolBuiltinStaticNonVoidUnaryMethod(IMethodSymbol method)
        {
            if (method.ReturnType.SpecialType == SpecialType.System_Boolean
                && method.ReturnType == method.Parameters[0].Type)
            {
                Func<BoolExpr, BoolExpr> z3Constructor = null;
                switch (method.Name)
                {
                    case "op_LogicalNot":
                        z3Constructor = Ctx.MkNot;
                        break;
                }
                if (z3Constructor != null)
                {
                    return LiftZ3Op1(z3Constructor, Mapper.BoolSortMapping.MutatorForValue, Mapper.BoolSortMapping);
                }
            }
            throw new SymbolicExplorationException("No lifted counterpart found for " + method);
        }
        #endregion

        #region static T1 (T2,T3)
        public Func<Mutator, Mutator, Mutator> LiftStaticNonVoidBinaryMethod(IMethodSymbol method)
        {
            Contract.Requires(method.IsStatic);
            Contract.Requires(!method.ReturnsVoid);
            Contract.Requires(method.Arity == 2);

            return _static2.GetOrCreate(method, () =>
            {
                if (Mapper.IsIntBuiltin(method.ContainingType))
                {
                    return LiftIntBuiltinStaticNonVoidBinaryMethod(method);
                }
                if (method.ContainingType.SpecialType == SpecialType.System_Boolean)
                {
                    return LiftBoolBuiltinStaticNonVoidBinaryMethod(method);
                }
                throw new SymbolicExplorationException("No lifted counterpart found for " + method);
            });
        }

        Func<Mutator, Mutator, Mutator> LiftIntBuiltinStaticNonVoidBinaryMethod(IMethodSymbol method)
        {
            if (Mapper.IsIntBuiltin(method.ReturnType)
                && method.ReturnType == method.Parameters[0].Type)
            {
                // Functions where the return sort is the same as the first argument's


                // Ugly hack: use Int instead of the correct bitvector sort
                //var operandMapping = Mapper.BigIntSortMapping;
                //Func<IntExpr, IntExpr, Expr> z3Constructor = null;
                //switch (method.Name)
                //{
                //    case "op_Addition":
                //        z3Constructor = (lhs, rhs) => Ctx.MkAdd(lhs, rhs); break;
                //    case "op_Subtraction":
                //        z3Constructor = (lhs, rhs) => Ctx.MkSub(lhs, rhs); break;
                //    case "op_Multiply":
                //        z3Constructor = (lhs, rhs) => Ctx.MkMul(lhs, rhs); break;
                //    case "op_Division":
                //        z3Constructor = (lhs, rhs) => Ctx.MkDiv(lhs, rhs); break;
                //    case "op_Modulus":
                //        z3Constructor = (lhs, rhs) => Ctx.MkRem(lhs, rhs); break;
                //}

                // Here is the correct thing to do

                var operandMapping = Mapper.GetBitVecSortMapping(method.ReturnType);
                Func<BitVecExpr, BitVecExpr, BitVecExpr> z3Constructor = null;
                switch (method.Name)
                {
                    case "op_Addition":
                        z3Constructor = Ctx.MkBVAdd; break;
                    case "op_Subtraction":
                        z3Constructor = Ctx.MkBVSub; break;
                    case "op_Multiply":
                        z3Constructor = Ctx.MkBVMul; break;
                    case "op_Division":
                        if (operandMapping.IsSigned)
                        {
                            z3Constructor = Ctx.MkBVSDiv; break;
                        }
                        else
                        {
                            z3Constructor = Ctx.MkBVUDiv; break;
                        }
                    case "op_Modulus":
                        if (operandMapping.IsSigned)
                        {
                            z3Constructor = Ctx.MkBVSRem; break;
                        }
                        else
                        {
                            z3Constructor = Ctx.MkBVURem; break;
                        }
                    case "op_BitwiseAnd":
                        z3Constructor = Ctx.MkBVAND; break;
                    case "op_BitwiseOr":
                        z3Constructor = Ctx.MkBVOR; break;
                    case "op_ExclusiveOr":
                        z3Constructor = Ctx.MkBVXOR; break;
                    case "op_LeftShift":
                        z3Constructor = Ctx.MkBVSHL; break;
                    case "op_RightShift":
                        if (operandMapping.IsSigned)
                        {
                            z3Constructor = Ctx.MkBVASHR; break;
                        }
                        else
                        {
                            z3Constructor = Ctx.MkBVLSHR; break;
                        }
                }
                if (z3Constructor != null)
                {
                    return LiftZ3Op2(z3Constructor, operandMapping.MutatorForValue, operandMapping, operandMapping);
                }
            }

            if (method.ReturnType.SpecialType == SpecialType.System_Boolean
                && Mapper.IsIntBuiltin(method.Parameters[0].Type)
                && method.Parameters[0].Type == method.Parameters[1].Type)
            {
                // Ugly hack: use Int instead of the correct bitvector sort
                //var operandMapping = Mapper.BigIntSortMapping;
                //Func<ArithExpr, ArithExpr, BoolExpr> z3Constructor = null;
                //switch (method.Name)
                //{
                //    case "op_Equality":
                //        z3Constructor = Ctx.MkEq; break;
                //    case "op_Inequality":
                //        z3Constructor = ((v1, v2) => Ctx.MkNot(Ctx.MkEq(v1, v2))); break;
                //    case "op_GreaterThan":
                //        z3Constructor = Ctx.MkGt; break;
                //    case "op_GreaterThanOrEqual":
                //        z3Constructor = Ctx.MkGe; break;
                //    case "op_LessThan":
                //        z3Constructor = Ctx.MkLt; break;
                //    case "op_LessThanOrEqual":
                //        z3Constructor = Ctx.MkLe; break;
                //}

                // Here is the correct thing to do

                var operandMapping = Mapper.GetBitVecSortMapping(method.Parameters[0].Type);
                Func<BitVecExpr, BitVecExpr, BoolExpr> z3Constructor = null;
                switch (method.Name)
                {
                    case "op_Equality":
                        z3Constructor = Ctx.MkEq; break;
                    case "op_Inequality":
                        z3Constructor = ((v1, v2) => Ctx.MkNot(Ctx.MkEq(v1, v2))); break;
                    case "op_GreaterThan":
                        if (operandMapping.IsSigned)
                        {
                            z3Constructor = Ctx.MkBVSGT; break;
                        }
                        else
                        {
                            z3Constructor = Ctx.MkBVUGT; break;
                        }
                    case "op_GreaterThanOrEqual":
                        if (operandMapping.IsSigned)
                        {
                            z3Constructor = Ctx.MkBVSGE; break;
                        }
                        else
                        {
                            z3Constructor = Ctx.MkBVUGE; break;
                        }
                    case "op_LessThan":
                        if (operandMapping.IsSigned)
                        {
                            z3Constructor = Ctx.MkBVSLT; break;
                        }
                        else
                        {
                            z3Constructor = Ctx.MkBVULT; break;
                        }
                    case "op_LessThanOrEqual":
                        if (operandMapping.IsSigned)
                        {
                            z3Constructor = Ctx.MkBVSLE; break;
                        }
                        else
                        {
                            z3Constructor = Ctx.MkBVULE; break;
                        }
                }
                if (z3Constructor != null)
                {
                    return LiftZ3Op2(z3Constructor, Mapper.BoolSortMapping.MutatorForValue, operandMapping, operandMapping);
                }
            }
            throw new SymbolicExplorationException("No lifted counterpart found for " + method.Name);
        }

        Func<Mutator, Mutator, Mutator> LiftBoolBuiltinStaticNonVoidBinaryMethod(IMethodSymbol method)
        {
            if (method.ReturnType.SpecialType == SpecialType.System_Boolean
                && method.Parameters[0].Type.SpecialType == SpecialType.System_Boolean
                && method.Parameters[0].Type == method.Parameters[1].Type)
            {
                Func<BoolExpr, BoolExpr, BoolExpr> z3Constructor = null;
                switch (method.Name)
                {
                    case "op_BitwiseAnd":
                        z3Constructor = (op1, op2) => Ctx.MkAnd(op1, op2); break;
                    case "op_BitwiseOr":
                        z3Constructor = (op1, op2) => Ctx.MkOr(op1, op2); break;
                    case "op_ExclusiveOr":
                        z3Constructor = (op1, op2) => Ctx.MkXor(op1, op2); break;
                    case "op_Equality":
                        z3Constructor = Ctx.MkEq; break;
                    case "op_Inequality":
                        z3Constructor = ((v1, v2) => Ctx.MkNot(Ctx.MkEq(v1, v2))); break;

                }
                if (z3Constructor != null)
                {
                    return LiftZ3Op2(z3Constructor, Mapper.BoolSortMapping.MutatorForValue, Mapper.BoolSortMapping, Mapper.BoolSortMapping);
                }
            }
            throw new SymbolicExplorationException("No lifted counterpart found for " + method);
        }

        #endregion

        // The following functions lift functions on Z3 expressions to functions on Mutators

        Func<Mutator, Mutator> LiftZ3Op1<TOp1Expr, TReturnExpr>(Func<TOp1Expr, TReturnExpr> z3Constructor, Func<TReturnExpr, Mutator> mutatorConstructor,
            SortMapping op1Mapping)
            where TOp1Expr : Expr
            where TReturnExpr : Expr
        {
            return (op1) =>
            {
                var v1 = op1.Cast(op1Mapping);
                try
                {
                    return mutatorConstructor(z3Constructor((TOp1Expr)v1.CreateUpdate()));
                }
                catch (InvalidCastException)
                {
                    throw new SymbolicExplorationException("SortMapping does not match sort of Z3 constructor");
                }
            };
        }

        Func<Mutator, Mutator, Mutator> LiftZ3Op2<TOp1Expr, TOp2Expr, TReturnExpr>(Func<TOp1Expr, TOp2Expr, TReturnExpr> z3Constructor, Func<TReturnExpr, Mutator> mutatorConstructor,
            SortMapping op1Mapping, SortMapping op2Mapping)
            where TOp1Expr : Expr
            where TOp2Expr : Expr
            where TReturnExpr : Expr
        {
            return (op1, op2) =>
            {
                var v1 = op1.Cast(op1Mapping);
                var v2 = op2.Cast(op2Mapping);
                try
                {
                    return mutatorConstructor(z3Constructor((TOp1Expr)v1.CreateUpdate(), (TOp2Expr)v2.CreateUpdate()));
                }
                catch (InvalidCastException)
                {
                    throw new SymbolicExplorationException("SortMapping does not match sort of Z3 constructor");
                }
            };
        }
    }
}
