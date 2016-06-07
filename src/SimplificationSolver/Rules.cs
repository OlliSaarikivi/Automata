using Microsoft.Automata.Z3;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.SimplificationSolver
{
    static class Rules
    {
        public static IEnumerable<RuleEntry> GetRules()
        {
            yield return new RuleEntry("SimplifyPointlessIte", SimplifyPointlessIte);
            yield return new RuleEntry("ContextualSimplifyBool", ContextualSimplifyBool);
            yield return new RuleEntry("SimplifyIte", SimplifyIte);
        }

        static bool AreEquivalentUnder(Z3Provider ctx, Expr left, Expr right, Expr assumption)
        {
            return left.Equals(right) || ctx.IsValid(ctx.MkImplies(assumption, ctx.MkEq(left, right)));
        }

        static RuleResult SimplifyPointlessIte(Z3Provider ctx, Expr term, Expr path)
        {
            if (term.IsApp && term.FuncDecl.DeclKind == Z3_decl_kind.Z3_OP_ITE)
            {
                if (AreEquivalentUnder(ctx, term.Args[1], term.Args[2], path))
                {
                    int numAppsLeft = 0;
                    ExprWalker.PreOrderWalk(ctx, term.Args[1], (e, p) =>
                    {
                        ++numAppsLeft;
                        return true;
                    });
                    int numAppsRight = 0;
                    ExprWalker.PreOrderWalk(ctx, term.Args[2], (e, p) =>
                    {
                        ++numAppsRight;
                        return true;
                    });
                    return new RuleResult(numAppsLeft <= numAppsRight ? term.Args[1] : term.Args[2]);
                }
                if (AreEquivalentUnder(ctx, term, term.Args[2], path))
                    return new RuleResult(term.Args[2]);
                if (AreEquivalentUnder(ctx, term, term.Args[1], path))
                    return new RuleResult(term.Args[1]);
            }
            return new RuleResult(null);
        }

        static RuleResult ContextualSimplifyBool(Z3Provider ctx, Expr term, Expr path)
        {
            if (term.IsBool && ctx.IsSatisfiable(path))
            {
                if (!term.Equals(ctx.True) && ctx.IsValid(ctx.MkImplies(path, term)))
                    return new RuleResult(ctx.True);
                if (!term.Equals(ctx.False) && ctx.IsValid(ctx.MkImplies(path, ctx.MkNot(term))))
                    return new RuleResult(ctx.False);
            }
            return new RuleResult(null);
        }

        static RuleResult SimplifyIte(Z3Provider ctx, Expr term, Expr path)
        {
            if (term.IsApp && term.FuncDecl.DeclKind == Z3_decl_kind.Z3_OP_ITE)
            {
                if (term.Args[0].Equals(ctx.True))
                    return new RuleResult(term.Args[1]);
                if (term.Args[0].Equals(ctx.False))
                    return new RuleResult(term.Args[2]);
            }
            return new RuleResult(null);
        }
    }
}
