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

            ExprWalker.PreOrderWalk(ctx, term, (subterm, path) =>
            {
                if (subterm.IsBool)
                {
                    var left = ctx.ApplySubstitution(subterm, stateParam, leftSubst);
                    if (left.Equals(subterm))
                    {
                        suggestions.Add(subterm);
                        return false;
                    }
                    var right = ctx.ApplySubstitution(subterm, stateParam, rightSubst);
                    if (ctx.IsValid(ctx.MkImplies(path, ctx.Z3.MkForall(bothSubsts, ctx.MkEq(left, right)))))
                    {
                        suggestions.Add(SubstituteArbitraryConcretization(ctx, subterm, stateParam));
                        return false;
                    }
                }
                return true;
            });
            
            var filtered = new List<Expr>();
            foreach (Expr candidate in suggestions)
            {
                if (!filtered.Contains(candidate))
                    filtered.Add(candidate);
            }

            return filtered;
        }
    }
}
