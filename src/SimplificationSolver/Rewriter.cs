using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Automata.Z3;

namespace Microsoft.Automata.SimplificationSolver
{
    class Rewriter
    {
        const int ExpandAll = -1;

        class WorkItem
        {
            public Expr Path { get; set; }
        }

        class ExprWorkItem : WorkItem
        {
            public Expr Term { get; set; }
            public int ExpandLimit { get; set; }

            public ExprWorkItem(Expr term, int expandLimit, Expr path)
            {
                Term = term;
                Path = path;
                ExpandLimit = expandLimit < 0 ? ExpandAll : expandLimit;
            }
        }

        class AppWorkItem : WorkItem
        {
            public FuncDecl Decl { get; set; }
            public Expr OriginalApp { get; set; }

            public AppWorkItem(FuncDecl decl, Expr originalApp, Expr path)
            {
                Decl = decl;
                OriginalApp = originalApp;
                Path = path;
            }
        }


        class AppInfo
        {
            public bool ArgRewritten { get; set; }
            public AppInfo(bool argRewritten)
            {
                ArgRewritten = argRewritten;
            }
        }

        public List<RuleEntry> Rules { get; private set; } = new List<RuleEntry>();
        public int RulesMatched { get; private set; }

        public Rewriter()
        {
            Rules = new List<RuleEntry>();
        }

        public Expr Rewrite(Z3Provider ctx, Expr root, Expr initialPath = null)
        {
            ResetStats();

            var workStack = new Stack<WorkItem>();
            var appInfoStack = new Stack<AppInfo>();
            var arguments = new Stack<Expr>();
            appInfoStack.Push(new AppInfo(false));
            workStack.Push(new ExprWorkItem(root, ExpandAll, initialPath ?? ctx.True));

            Action<Expr, Expr> processTerm = (term, path) =>
            {
                foreach (var entry in Rules)
                {
                    var result = entry.Rule(ctx, term, path);
                    if (result.Term != null)
                    {
                        appInfoStack.Peek().ArgRewritten = true;
#if DEBUG
                        if (!ctx.IsValid(ctx.MkImplies(path, ctx.MkEq(term, result.Term))))
                            throw new AutomataException(entry.Name + " did not preserve equivalence. Rewrote \'" + term +
                                "\' into \'" + result.Term + "\' under the assumption \'" + ctx.Simplify(path) + "\'");
#endif
                        term = result.Term;
                        ++RulesMatched;

                        if (result.ReinspectDepth > 0)
                        {
                            workStack.Push(new ExprWorkItem(term, result.ReinspectDepth - 1, path));
                            return;
                        }
                    }
                }
                arguments.Push(term);
            };

            while (workStack.Count > 0)
            {
                var item = workStack.Pop();
                if (item is ExprWorkItem)
                {
                    var exprItem = (ExprWorkItem)item;
                    var term = exprItem.Term;
                    if (term.IsApp)
                    {
                        if (exprItem.ExpandLimit != 0)
                        {
                            workStack.Push(new AppWorkItem(term.FuncDecl, term, item.Path));
                            appInfoStack.Push(new AppInfo(false));
                            int newLimit = exprItem.ExpandLimit - 1;

                            if (term.FuncDecl.DeclKind == Z3_decl_kind.Z3_OP_ITE)
                            {
                                workStack.Push(new ExprWorkItem(term.Args[2], newLimit, ctx.MkAnd(item.Path, ctx.MkNot(term.Args[0]))));
                                workStack.Push(new ExprWorkItem(term.Args[1], newLimit, ctx.MkAnd(item.Path, term.Args[0])));
                                workStack.Push(new ExprWorkItem(term.Args[0], newLimit, item.Path));
                            }
                            else
                                for (int i = term.Args.Length - 1; i >= 0; --i)
                                    workStack.Push(new ExprWorkItem(term.Args[i], newLimit, item.Path));
                        }
                        else
                            processTerm(term, item.Path);
                    }
                    else if (term.IsNumeral || term.IsVar)
                    {
                        processTerm(term, item.Path);
                    }
                    else
                        throw new AutomataException("Unsupported term: " + term);
                }
                else if (item is AppWorkItem)
                {
                    var appItem = (AppWorkItem)item;
                    var decl = appItem.Decl;

                    if (arguments.Count < decl.Arity)
                        throw new AutomataException("Ran out of arguments");

                    var term = appItem.OriginalApp;
                    bool argRewritten = appInfoStack.Pop().ArgRewritten;
                    var appArguments = new Expr[decl.Arity];
                    for (int i = 0; i < decl.Arity; ++i)
                    {
                        appArguments[decl.Arity - 1 - i] = arguments.Pop();
                    }
                    if (argRewritten)
                    {
                        term = ctx.MkApp(decl, appArguments);
                        appInfoStack.Peek().ArgRewritten = true;
                    }
                    processTerm(term, item.Path);
                }
                else
                    Debug.Assert(false);
            }

            if (arguments.Count == 0)
                throw new AutomataException("No value left on argument stack after rewrite");
            if (arguments.Count > 1)
                throw new AutomataException(arguments.Count + " values left on argument stack after rewrite");

#if DEBUG
            if (!ctx.IsValid(ctx.MkEq(root, arguments.Peek())))
            {
                throw new AutomataException("Rewrite did not preserve equivalence");
            }
#endif

            return arguments.Peek();
        }

        private void ResetStats()
        {
            RulesMatched = 0;
        }
    }
}
