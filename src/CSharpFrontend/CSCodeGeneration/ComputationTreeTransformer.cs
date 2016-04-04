using Microsoft.Automata;
using Microsoft.Automata.Z3;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.CodeGeneration
{
    static class ComputationTreeTransformer
    {
        static public ComputationTree ToComputationTrees(STb<FuncDecl, Expr, Sort> stb, bool includeOutput)
        {
            var ctx = ((Z3Provider)stb.Solver).Z3;

            var states = stb.States.Select((State, Index) => new { State, Index, Name = "S" + State });
            var csEnumSort = ctx.IntSort;
            var outputListSort = stb.OutputListSort as ListSort;
            var resultSort = ctx.MkTupleSort(ctx.MkSymbol(stb.Name + "#STATE"),
                new[] { ctx.MkSymbol("#CS"), ctx.MkSymbol("#OUT"), ctx.MkSymbol("#VARS") },
                new[] { csEnumSort, outputListSort, stb.RegisterSort });
            var csField = resultSort.FieldDecls[0];
            var outputField = resultSort.FieldDecls[1];
            var registerField = resultSort.FieldDecls[2];

            var inputVar = stb.Solver.MkVar(0, stb.InputSort);
            var registerVar = stb.Solver.MkVar(1, stb.RegisterSort);
            var computationVar = stb.Solver.MkVar(2, resultSort);

            var csProjection = csField.Apply(computationVar);
            var outputProjection = outputField.Apply(computationVar);
            var registerProjection = registerField.Apply(computationVar);

            Func<int, Expr[], Expr, Expr> createResult = (state, yields, register) =>
            {
                Expr output;

                if (includeOutput)
                {
                    output = yields.Length == 0 ? outputProjection : ctx.MkFuncDecl("Append", new Sort[] { outputListSort, outputListSort }, outputListSort).Apply(
                        outputProjection, ctx.MkFuncDecl("List", yields.Select(x => x.Sort).ToArray(), outputListSort).Apply(yields));
                }
                else
                {
                    output = outputProjection;
                }
                var result = resultSort.MkDecl.Apply(
                    ctx.MkInt(state),
                    output,
                    register != null ? register : registerProjection);
                return result.Substitute(registerVar, registerProjection);
            };

            ComputationNode ruleNode;
            var stateComps = stb.States.Select(State => new { State, Computation = ToComputationTree(ctx, stb.GetRuleFrom(State), registerVar, registerProjection, createResult) }).ToList();
            if (stateComps.Count == 0)
            {
                ruleNode = new UndefinedNode();
            }
            else 
            {
                ruleNode = new SwitchNode(stateComps.Select(x => ctx.MkEq(csProjection, ctx.MkInt(x.State))).ToArray(), stateComps.Select(x => x.Computation).ToArray());
            }

            ComputationNode finalNode;
            var finalComps = stb.States.Where(s => stb.IsFinalState(s))
                .Select(State => new { State, Computation = ToComputationTree(ctx, stb.GetFinalRuleFrom(State), registerVar, registerProjection, createResult) }).ToList();
            if (finalComps.Count == 0)
            {
                finalNode = new UndefinedNode();
            }
            else
            {
                finalNode = new SwitchNode(finalComps.Select(x => ctx.MkEq(csProjection, ctx.MkInt(x.State))).ToArray(), finalComps.Select(x => x.Computation).ToArray());
            }

            var initialState = resultSort.MkDecl.Apply(
                    ctx.MkInt(stb.InitialState),
                    outputListSort.Nil,
                    stb.InitialRegister);

            return new ComputationTree
            {
                Move = ruleNode,
                Finish = finalNode,
                InitialState = initialState,
                EnumSorts = new EnumSort[] { },
            };
        }

        static ComputationNode ToComputationTree(Context ctx, STbRule<Expr> rule, Expr registerVar, Expr registerProjection, Func<int, Expr[], Expr, Expr> createResult)
        {
            var iteRule = rule as IteRule<Expr>;
            if (iteRule != null)
            {
                var trueNode = ToComputationTree(ctx, iteRule.TrueCase, registerVar, registerProjection, createResult);
                var falseNode = ToComputationTree(ctx, iteRule.FalseCase, registerVar, registerProjection, createResult);
                var lifted = iteRule.Condition.Substitute(registerVar, registerProjection);
                return new IteNode(lifted, trueNode, falseNode);
            }

            var baseRule = rule as BaseRule<Expr>;
            if (baseRule != null)
            {
                return new ResultNode(createResult(baseRule.State, baseRule.Yields.ToArray(), baseRule.Register));
            }

            var raiseRule = rule as UndefRule<Expr>;
            if (raiseRule != null)
            {
                return new UndefinedNode();
            }

            throw new CodeGenerationException("Unsupported STb rule type");
        }
    }
}
