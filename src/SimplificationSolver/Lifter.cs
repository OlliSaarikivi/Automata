using Microsoft.Automata.Z3;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.SimplificationSolver
{
    static class Lifter
    {
        static STb<FuncDecl, Expr, Sort> ToStateComputationSTb(STb<FuncDecl, Expr, Sort> stb)
        {
            var ctx = stb.Solver as Z3Provider;
            if (ctx == null)
                throw new AutomataException("Solver must be Z3");

            var csSort = ctx.IntSort;
            FuncDecl csAndRegsConstructor;
            FuncDecl[] csAndRegsProjections;
            var csAndRegsSort = ctx.MkTupleSort(stb.Name + "#STATE",
                new String[] { "#CS", "#REGS" },
                new Sort[] { csSort, stb.RegisterSort }, out csAndRegsConstructor, out csAndRegsProjections);
            var csAndRegsVar = ctx.MkVar(1, csAndRegsSort);

            var csProjection = csAndRegsProjections[0].Apply(csAndRegsVar);
            var registerProjection = csAndRegsProjections[1].Apply(csAndRegsVar);

            Func<STbRule<Expr>, Expr> ruleToExpr = null;
            ruleToExpr = rule =>
            {
                var iteRule = rule as IteRule<Expr>;
                if (iteRule != null)
                {
                    var ifTrue = ruleToExpr(iteRule.TrueCase);
                    var ifFalse = ruleToExpr(iteRule.FalseCase);
                    var lifted = iteRule.Condition.Substitute(stb.RegVar, registerProjection);
                    return ctx.MkIte(lifted, ifTrue, ifFalse);
                }

                var baseRule = rule as BaseRule<Expr>;
                if (baseRule != null)
                {
                    return ctx.MkApp(csAndRegsConstructor, ctx.MkInt(baseRule.State), baseRule.Register);
                }

                throw new AutomataException("Unsupported rule: " + rule);
            };

            var states = new Stack<int>(stb.States);
            var stateTransferTerm = ruleToExpr(stb.GetRuleFrom(states.Pop()));
            while (states.Count > 0)
            {
                var state = states.Pop();
                var stateTerm = ruleToExpr(stb.GetRuleFrom(state));
                var condition = ctx.MkEq(csProjection, ctx.MkInt(state));
                stateTransferTerm = ctx.MkIte(condition, stateTerm, stateTransferTerm);
            }

            var p = new Program
            {
                Body = stateTransferTerm,
                InputParam = stb.InputVar,
                StateParam = csAndRegsVar,
            };

            var explorer = new Explorer(ctx);
            explorer.Explore(p, 20);

            var constructors = new List<Constructor>();
            constructors.Add(ctx.Z3.MkConstructor(stb.Name + "#Args0", "Is" + stb.Name + "#Args0"));
            int i = 1;
            var shapeToState = new Dictionary<Shape, int>();
            var declToShape = new Dictionary<FuncDecl, Shape>();
            foreach (var shape in p.Shapes)
            {
                var name = stb.Name + "#Args" + i;
                var constructor = ctx.Z3.MkConstructor(name, "Is" + name, sorts: shape.Parameters.Select(x => x.Sort).ToArray());
                constructors.Add(constructor);
                shapeToState.Add(shape, i);
                declToShape.Add(shape.Declaration, shape);
                ++i;
            }
            var shapeArgumentsSort = ctx.Z3.MkDatatypeSort(stb.Name + "#ArgumentsSort", constructors.ToArray());

            var scStb = new STb<FuncDecl, Expr, Sort>(ctx, stb.Name + "#StateComputer", stb.InputSort, csAndRegsSort,
                shapeArgumentsSort, constructors[0].ConstructorDecl.Apply(), 0);

            Func<Expr, STbRule<Expr>> templateToRule = null;
            templateToRule = template =>
            {
                Debug.Assert(template.IsApp);
                if (template.FuncDecl.DeclKind == Z3_decl_kind.Z3_OP_ITE)
                {
                    return new IteRule<Expr>(template.Args[0], templateToRule(template.Args[1]), templateToRule(template.Args[2]));
                } else
                {
                    var shape = declToShape[template.FuncDecl];
                    var targetState = shapeToState[shape];
                    return new BaseRule<Expr>(Sequence<Expr>.Empty,
                        constructors[targetState].ConstructorDecl.Apply(template.Args),
                        targetState);
                }
            };

            var batchStateVar = ctx.MkVar(2, csAndRegsSort);

            scStb.AssignRule(0, templateToRule(p.InitialApplication));
            scStb.AssignFinalRule(0, new BaseRule<Expr>(new Sequence<Expr>(batchStateVar), scStb.RegVar, 0));
            foreach (var shape in p.Shapes)
            {
                var state = shapeToState[shape];
                scStb.AssignRule(state, templateToRule(shape.CompositionTemplate));

                var output = shape.Body.Substitute(p.StateParam, batchStateVar);
                var constructor = constructors[state];
                foreach (var x in shape.Parameters.Zip(constructor.AccessorDecls, (param, accessor) => new { param, accessor }))
                {
                    output = output.Substitute(x.param, x.accessor.Apply(scStb.RegVar));
                }
                scStb.AssignFinalRule(state, new BaseRule<Expr>(new Sequence<Expr>(output), scStb.RegVar, 0));
            }

            return scStb;
        }
    }
}
