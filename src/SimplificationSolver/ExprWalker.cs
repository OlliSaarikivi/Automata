using Microsoft.Automata.Z3;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.SimplificationSolver
{
    static class ExprWalker
    {
        class PreOrderWalkWorkItem
        {
            public Expr Term { get; set; }
            public Expr Path { get; set; }

            public PreOrderWalkWorkItem(Expr term, Expr path)
            {
                Term = term;
                Path = path;
            }
        };
        
        public static void PreOrderWalk(Z3Provider ctx, Expr root, Func<Expr, Expr, bool> visit)
        {
            var workStack = new Stack<PreOrderWalkWorkItem>();
            workStack.Push(new PreOrderWalkWorkItem(root, ctx.True));

            while (workStack.Count > 0)
            {
                var item = workStack.Pop();
                bool descend = visit(item.Term, item.Path);
                if (item.Term.IsApp && descend)
                {
                    if (item.Term.FuncDecl.DeclKind == Z3_decl_kind.Z3_OP_ITE)
                    {
                        workStack.Push(new PreOrderWalkWorkItem(item.Term.Args[2], ctx.MkAnd(item.Path, ctx.MkNot(item.Term.Args[0]))));
                        workStack.Push(new PreOrderWalkWorkItem(item.Term.Args[1], ctx.MkAnd(item.Path, item.Term.Args[0])));
                        workStack.Push(new PreOrderWalkWorkItem(item.Term.Args[0], item.Path));
                    }
                    else
                        for (int i = item.Term.Args.Length - 1; i >= 0; --i)
                            workStack.Push(new PreOrderWalkWorkItem(item.Term.Args[i], item.Path));
                }
            }
        }

    }
}
