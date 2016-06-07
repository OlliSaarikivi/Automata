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
    static class Assumer
    {
        static Expr ValueOfSort(Z3Provider ctx, Sort sort)
        {
            if (sort.SortKind == Z3_sort_kind.Z3_BV_SORT)
                return ctx.Z3.MkBV(0, ((BitVecSort)sort).Size);
            else if (sort.SortKind == Z3_sort_kind.Z3_BOOL_SORT)
                return ctx.True;
            else if (sort.SortKind == Z3_sort_kind.Z3_DATATYPE_SORT)
            {
                var dtSort = (DatatypeSort)sort;
                var decl = dtSort.Constructors[0];
                return ctx.MkApp(decl, (from paramSort in decl.Domain
                                        select ValueOfSort(ctx, paramSort)).ToArray());
            }
            else if (sort.SortKind == Z3_sort_kind.Z3_FINITE_DOMAIN_SORT)
            {
                var fdSort = (FiniteDomainSort)sort;
                throw new AutomataException("Unsupported sort: " + sort);
            }
            else
                throw new AutomataException("Unsupported sort: " + sort);
        }

        static Expr SubstituteArbitraryConcretization(Z3Provider ctx, Expr term, Expr var)
        {
            return term.Substitute(var, ValueOfSort(ctx, var.Sort));
        }

        public static IEnumerable<Expr> GetSuggestions(Z3Provider ctx, Expr term, Expr stateParam)
        {
            var suggestions = new List<Expr>();

            Expr leftSubst = ctx.MkConst("#1", stateParam.Sort);
            Expr rightSubst = ctx.MkConst("#2", stateParam.Sort);
            var bothSubsts = new Expr[] { leftSubst, rightSubst };

            Func<Expr, Expr, Expr> getAsRuntimeConcrete = (subterm, path) =>
            {
                var left = ctx.ApplySubstitution(subterm, stateParam, leftSubst);
                if (left.Equals(subterm))
                {
                    return subterm;
                }
                var right = ctx.ApplySubstitution(subterm, stateParam, rightSubst);
                if (ctx.IsValid(ctx.MkImplies(path, ctx.Z3.MkForall(bothSubsts, ctx.MkEq(left, right)))))
                {
                    return SubstituteArbitraryConcretization(ctx, subterm, stateParam);
                }
                return null;
            };

            ExprWalker.PreOrderWalk(ctx, term, (subterm, path) =>
            {
                if (subterm.IsBool)
                {
                    var concrete = getAsRuntimeConcrete(subterm, path);
                    if (concrete != null)
                    {
                        suggestions.Add(concrete);
                        return false;
                    }
                }
                //if (subterm.IsBV && subterm.IsApp)
                //{
                //    if (subterm.FuncDecl.DeclKind == Z3_decl_kind.Z3_OP_BADD)
                //    {
                //        var addition = ctx.MkBvAdd(ctx.Z3.MkZeroExt(1, (BitVecExpr)subterm.Args[0]),
                //            ctx.Z3.MkZeroExt(1, (BitVecExpr)subterm.Args[1]));
                //        var size = ((BitVecSort)subterm.Sort).Size;
                //        var highBit = ctx.Z3.MkExtract(size, size, (BitVecExpr)addition);
                //        var didOverflow = ctx.MkEq(highBit, ctx.Z3.MkBV(1, 1));
                //        suggestions.Add(didOverflow);
                //    }
                //}
                return true;
            });
            
            var filtered = new List<Expr>();
            foreach (Expr candidate in suggestions)
            {
                if (!filtered.Contains(candidate))
                    filtered.Add(candidate.Simplify());
            }

            return filtered;
        }
    }
}
