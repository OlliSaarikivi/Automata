using Microsoft.Automata;
using Microsoft.Automata.Z3;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplificationSolver.Test
{
    class RegexToTransducer
    {
        public static STb<FuncDecl, Expr, Sort> Convert(Z3Provider ctx, string regex, string name = "MatchPositionsSTb")
        {
            var a = ctx.RegexConverter.Convert(regex);
            a = a.Determinize(ctx);
            var stb = new STb<FuncDecl, Expr, Sort>(ctx, name, ctx.MkBitVecSort(16), ctx.BoolSort, ctx.BoolSort, ctx.True, a.InitialState);
            var sinkState = a.MaxState + 1;
            var sinkRule = new BaseRule<Expr>(Sequence<Expr>.Empty, ctx.True, sinkState);
            stb.AssignRule(sinkState, sinkRule);
            foreach (int state in a.States)
            {
                STbRule<Expr> current = sinkRule;
                foreach (var move in a.GetMovesFrom(state))
                {
                    Debug.Assert(!move.IsEpsilon);
                    var yields = a.IsFinalState(move.TargetState) ? new Sequence<Expr>(ctx.True) : Sequence<Expr>.Empty;
                    var moveRule = new BaseRule<Expr>(yields, ctx.True, move.TargetState);
                    current = new IteRule<Expr>(move.Label, moveRule, current);

                }
                stb.AssignRule(state, current);
            }
            var finalRule = new BaseRule<Expr>(Sequence<Expr>.Empty, ctx.True, a.InitialState);
            foreach (int state in stb.States)
            {
                stb.AssignFinalRule(state, finalRule);
            }
            return stb;
            //var a = ctx.RegexConverter.Convert(regex);
            //a = a.Determinize(ctx);
            //var counterSort = ctx.MkBitVecSort(32);
            //var stb = new STb<FuncDecl, Expr, Sort>(ctx, name, ctx.MkBitVecSort(16), counterSort, counterSort, ctx.Z3.MkBV(0, 32), a.InitialState);
            //var sinkState = a.MaxState + 1;
            //var sinkRule = new BaseRule<Expr>(Sequence<Expr>.Empty, ctx.Z3.MkBV(0, 32), sinkState);
            //stb.AssignRule(sinkState, sinkRule);
            //foreach (int state in a.States)
            //{
            //    STbRule<Expr> current = sinkRule;
            //    foreach (var move in a.GetMovesFrom(state))
            //    {
            //        Debug.Assert(!move.IsEpsilon);
            //        var yields = a.IsFinalState(move.TargetState) ? new Sequence<Expr>(ctx.Z3.MkBV(1, 32)) : Sequence<Expr>.Empty;
            //        var moveRule = new BaseRule<Expr>(yields, ctx.MkBvAdd(stb.RegVar, ctx.Z3.MkBV(1, 32)), move.TargetState);
            //        current = new IteRule<Expr>(move.Label, moveRule, current);

            //    }
            //    stb.AssignRule(state, current);
            //}
            //var finalRule = new BaseRule<Expr>(Sequence<Expr>.Empty, ctx.Z3.MkBV(0, 32), a.InitialState);
            //foreach (int state in stb.States)
            //{
            //    stb.AssignFinalRule(state, finalRule);
            //}
            //return stb;
        }
    }
}
