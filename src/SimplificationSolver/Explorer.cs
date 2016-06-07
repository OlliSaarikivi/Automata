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
    class Explorer
    {
        long nextId = 1;
        Z3Provider ctx;

        public Explorer(Z3Provider ctx)
        {
            this.ctx = ctx;
        }

        class ExprOrFuncDecl { }
        class JustExpr : ExprOrFuncDecl
        {
            public Expr Term { get; set; }
            public JustExpr(Expr term) { Term = term; }
        }
        class JustFuncDecl : ExprOrFuncDecl
        {
            public FuncDecl Decl { get; set; }
            public JustFuncDecl(FuncDecl decl) { Decl = decl; }
        }

        Expr Compose(Expr inner, Program p)
        {
            var workStack = new Stack<ExprOrFuncDecl>();
            var arguments = new Stack<Expr>();
            workStack.Push(new JustExpr(inner));

            Func<Expr, Expr> composeLeaf = leaf =>
            {
                return p.Body.Substitute(p.StateParam, leaf);
            };

            while (workStack.Count > 0)
            {
                var item = workStack.Pop();
                if (item is JustExpr)
                {
                    var term = ((JustExpr)item).Term;
                    if (term.IsApp)
                    {
                        if (term.FuncDecl.DeclKind == Z3_decl_kind.Z3_OP_ITE)
                        {
                            workStack.Push(new JustFuncDecl(term.FuncDecl));
                            workStack.Push(new JustExpr(term.Args[2]));
                            workStack.Push(new JustExpr(term.Args[1]));
                            arguments.Push(term.Args[0]); // Don't "compose" the condition
                        }
                        else
                        {
                            arguments.Push(composeLeaf(term));
                        }
                    }
                    else if (term.IsNumeral || term.IsVar)
                    {
                        arguments.Push(composeLeaf(term));
                    }
                    else
                        throw new AutomataException("Unsupported term: " + term);
                }
                else if (item is JustFuncDecl)
                {
                    var decl = ((JustFuncDecl)item).Decl;

                    if (arguments.Count < decl.Arity)
                        throw new AutomataException("Ran out of arguments");

                    var appArguments = new Expr[decl.Arity];
                    for (int i = 0; i < decl.Arity; ++i)
                    {
                        appArguments[decl.Arity - 1 - i] = arguments.Pop();
                    }
                    arguments.Push(ctx.MkApp(decl, appArguments));
                }
                else
                    Debug.Assert(false);
            }

            if (arguments.Count == 0)
                throw new AutomataException("No value left on argument stack after composition");
            if (arguments.Count > 1)
                throw new AutomataException(arguments.Count + " values left on argument stack after composition");

            return arguments.Peek();
        }

        class SubstitutedBody
        {
            public Expr Body { get; set; }
            public List<Expr> Substituted { get; set; }
            public List<Expr> Params { get; set; }
        }

        SubstitutedBody ExprToBody(Expr term, Program p)
        {
            var ordered = new List<Expr>();

            ExprWalker.PreOrderWalk(ctx, term, (subterm, path) =>
            {
                if (subterm.IsConst && !subterm.Equals(p.StateParam) && !ordered.Contains(subterm))
                {
                    ordered.Add(subterm);
                }
                return true;
            });
            var substs = new Expr[ordered.Count];
            var parameters = new Expr[ordered.Count];
            var returnParams = new List<Expr>();
            int i = 0;
            foreach (Expr c in ordered)
            {
                substs[i] = c;
                var param = ctx.MkConst("c" + (i + 1), c.Sort);
                parameters[i] = param;
                returnParams.Add(param);
                ++i;
            }

            var result = new SubstitutedBody
            {
                Body = term.Substitute(substs, parameters),
                Substituted = ordered,
                Params = returnParams,
            };
            return result;
        }

        Expr CreateSimplifications(Expr term, Program p, Rewriter rewriter)
        {
            term = term.Simplify();
            var rewriteTargets = new HashSet<Expr> { term };
            bool somethingSimplified;
            do
            {
                somethingSimplified = false;
                var assumptions = rewriteTargets.SelectMany(target => Assumer.GetSuggestions(ctx, target, p.StateParam)).ToArray();
                foreach (var assumption in assumptions)
                {
                    Expr newTerm = null;
                    HashSet<Expr> newTargets = new HashSet<Expr>();
                    int totalMatches = 0;
                    Action<Expr> rewrite = path =>
                    {
                        newTerm = term;
                        totalMatches = 0;
                        foreach (var target in rewriteTargets)
                        {
                            var newTarget = rewriter.Rewrite(ctx, target, path);
                            newTargets.Add(newTarget);
                            if (rewriter.RulesMatched != 0)
                            {
                                newTerm = newTerm.Substitute(target, newTarget);
                                totalMatches += rewriter.RulesMatched;
                            }
                        }
                    };

                    rewrite(assumption);
                    if (totalMatches == 0)
                        continue;
                    Expr ifTrue = newTerm;

                    rewrite(ctx.MkNot(assumption));
                    if (totalMatches == 0)
                        continue;
                    Expr ifFalse = newTerm;

                    term = rewriter.Rewrite(ctx, ctx.MkIte(assumption, ifTrue, ifFalse));
                    rewriteTargets = newTargets;
                    somethingSimplified = true;
                }
            } while (somethingSimplified);



            return term;
        }

        Shape NewShape(Expr body, List<Expr> parameters, Program p, Rewriter rewriter)
        {
            var paramSorts = (from param in parameters
                              select param.Sort).ToArray();
            var decl = ctx.MkFuncDecl("S" + nextId++, paramSorts, body.Sort);

            Expr composition = CreateSimplifications(Compose(body, p), p, rewriter);

            var newShape = new Shape
            {
                Declaration = decl,
                Body = body,
                Composition = composition,
            };
            newShape.Parameters.AddRange(parameters);
            return newShape;
        }

        Pair<Shape, IEnumerable<Expr>> ShapeFor(Expr term, Program p, Rewriter rewriter)
        {
            var ret = ExprToBody(term, p);

            foreach (var shape in p.Shapes)
            {
                if (shape.Body.Equals(ret.Body))
                    return new Pair<Shape, IEnumerable<Expr>>(shape, ret.Substituted);
            }

            var newShape = NewShape(ret.Body, ret.Params, p, rewriter);
            p.Shapes.Add(newShape);
            return new Pair<Shape, IEnumerable<Expr>>(newShape, ret.Substituted);
        }

        void MatchShapes(List<Shape> newWave, Shape shape, Program p, Rewriter rewriter)
        {
            if (shape.CompositionTemplate != null)
                return;

            var workStack = new Stack<ExprOrFuncDecl>();
            var arguments = new Stack<Expr>();
            workStack.Push(new JustExpr(shape.Composition));

            Func<Expr, Expr> getReplacement = term =>
            {
                var ret = ShapeFor(term, p, rewriter);
                newWave.Add(ret.First);
                return ctx.MkApp(ret.First.Declaration, ret.Second.ToArray());
            };

            while (workStack.Count > 0)
            {

                var item = workStack.Pop();
                if (item is JustExpr)
                {
                    var term = ((JustExpr)item).Term;
                    if (term.IsApp)
                    {
                        if (term.FuncDecl.DeclKind == Z3_decl_kind.Z3_OP_ITE)
                        {
                            bool hasStateVar = false;
                            ExprWalker.PreOrderWalk(ctx, term.Args[0], (subterm, path) =>
                            {
                                if (subterm.Equals(p.StateParam))
                                    hasStateVar = true;
                                return true;
                            });

                            if (hasStateVar)
                            {
                                arguments.Push(getReplacement(term));
                            }
                            else
                            {
                                workStack.Push(new JustFuncDecl(term.FuncDecl));
                                workStack.Push(new JustExpr(term.Args[2]));
                                workStack.Push(new JustExpr(term.Args[1]));
                                arguments.Push(term.Args[0]);
                            }
                        }
                        else
                        {
                            arguments.Push(getReplacement(term));
                        }
                    }
                    else if (term.IsNumeral || term.IsVar)
                    {
                        arguments.Push(getReplacement(term));
                    }
                    else
                        throw new AutomataException("Unsupported term: " + term);
                }
                else if (item is JustFuncDecl)
                {
                    var decl = ((JustFuncDecl)item).Decl;

                    if (arguments.Count < decl.Arity)
                        throw new AutomataException("Ran out of arguments");

                    var appArguments = new Expr[decl.Arity];
                    for (int i = 0; i < decl.Arity; ++i)
                    {
                        appArguments[decl.Arity - 1 - i] = arguments.Pop();
                    }
                    arguments.Push(ctx.MkApp(decl, appArguments));
                }
                else
                    Debug.Assert(false);
            }


            if (arguments.Count == 0)
                throw new AutomataException("No value left on argument stack after shape replacement");
            if (arguments.Count > 1)
                throw new AutomataException(arguments.Count + " values left on argument stack after shape replacement");

            shape.CompositionTemplate = arguments.Peek();
        }

        public void Explore(Program p, int maxDepth)
        {
            nextId = 1;
            var rewriter = new Rewriter();
            rewriter.Rules.AddRange(Rules.GetRules());

            var wave = new List<Shape>();
            var ret = ShapeFor(rewriter.Rewrite(ctx, p.Body), p, rewriter);
            wave.Add(ret.First);

            int depth = 0;
            while(wave.Count > 0)
            {
                if (depth == maxDepth)
                    throw new AutomataException("Maximum depth reached");
                ++depth;

                var newWave = new List<Shape>();

                foreach (var shape in wave)
                {
                    MatchShapes(newWave, shape, p, rewriter);
                }
                wave = newWave;
            }

            p.InitialApplication = ctx.MkApp(ret.First.Declaration, ret.Second.ToArray());
        }

    }
}
