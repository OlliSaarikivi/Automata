using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Research.RiSE.TransducerCompiler.SymbolicExploration.ControlFlow
{
    abstract class Terminator
    {
    }

    class ReturnTerminator : Terminator
    {
        public ExpressionSyntax Value { get; private set; }

        public ReturnTerminator(ExpressionSyntax value)
        {
            Value = value;
        }
    }

    class YieldBreakTerminator : Terminator
    {
    }

    class JumpTerminator : Terminator
    {
        public BasicBlock Target { get; private set; }

        public JumpTerminator(BasicBlock target)
        {
            Contract.Requires(target != null);

            Target = target;
        }
    }

    class BranchTerminator : Terminator
    {
        public ExpressionSyntax Condition { get; private set; }
        public BasicBlock IfTrue { get; private set; }
        public BasicBlock IfFalse { get; private set; }

        public BranchTerminator(ExpressionSyntax condition, BasicBlock ifTrue, BasicBlock ifFalse)
        {
            Contract.Requires(condition != null);
            Contract.Requires(ifTrue != null);
            Contract.Requires(ifFalse != null);

            Condition = condition;
            IfTrue = ifTrue;
            IfFalse = ifFalse;
        }
    }

    class SwitchTerminator : Terminator
    {
        public struct Case
        {
            public ExpressionSyntax[] Labels { get; private set; }
            public StatementSyntax[] Statements { get; private set; }
            public bool IsDefault { get; private set; }

            public Case(ExpressionSyntax[] labels, StatementSyntax[] statements, bool isDefault)
                : this()
            {
                Labels = labels;
                Statements = statements;
                IsDefault = isDefault;
            }
        }

        public Case[] Cases { get; private set; }

        public SwitchTerminator(Case[] cases)
        {
            Cases = cases;
        }
    }

    class ThrowTerminator : Terminator
    {
        public ExpressionSyntax Exception { get; private set; }

        public ThrowTerminator(ExpressionSyntax exception)
        {
            Exception = exception;
        }
    }
}
