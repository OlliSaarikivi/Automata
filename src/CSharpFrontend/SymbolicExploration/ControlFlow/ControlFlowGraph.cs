using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.SymbolicExploration.ControlFlow
{
    /// <summary>
    /// Implements limited CFG construction. Exceptions in particular are not supported.
    /// </summary>
    class ControlFlowGraph
    {
        public BasicBlock EntryPoint { get; private set; }

        public ControlFlowGraph(BlockSyntax body, SemanticModel model)
        {
            var visitor = new CFGVisitor(this);
            visitor.PopulateCFG(body, model);
        }

        class CFGVisitor : CSharpSyntaxVisitor
        {
            ControlFlowGraph _cfg;
            SemanticModel _model;
            // The tuple elements are the list of statements to process, the block to add the statements to (this during processing when terminators are encountered),
            // the target block for continue statements inside the block, and the target block for break statements inside the block.
            Queue<Tuple<Stack<CSharpSyntaxNode>, BasicBlock, BasicBlock, BasicBlock>> _workQueue;
            Stack<CSharpSyntaxNode> _nextNodes;
            BasicBlock _currentBlock;
            BasicBlock _continueBlock;
            BasicBlock _breakBlock;
            Dictionary<ILabelSymbol, BasicBlock> _labels;

            public CFGVisitor(ControlFlowGraph cfg)
            {
                _cfg = cfg;
            }

            public void PopulateCFG(BlockSyntax body, SemanticModel model)
            {
                Debug.Assert(_cfg.EntryPoint == null);

                _model = model;
                _workQueue = new Queue<Tuple<Stack<CSharpSyntaxNode>, BasicBlock, BasicBlock, BasicBlock>>();
                _cfg.EntryPoint = new BasicBlock(new ReturnTerminator(null));
                _labels = new Dictionary<ILabelSymbol, BasicBlock>();
                _workQueue.Enqueue(Tuple.Create<Stack<CSharpSyntaxNode>, BasicBlock, BasicBlock, BasicBlock>(CreateNodeStack(body), _cfg.EntryPoint, null, null));

                while (_workQueue.Count > 0)
                {
                    var element = _workQueue.Dequeue();
                    _nextNodes = element.Item1;
                    _currentBlock = element.Item2;
                    _continueBlock = element.Item3;
                    _breakBlock = element.Item4;

                    while (_nextNodes.Count > 0)
                    {
                        Visit(_nextNodes.Pop());
                    }
                }
            }

            Stack<CSharpSyntaxNode> CreateNodeStack(params CSharpSyntaxNode[] nodes)
            {
                return new Stack<CSharpSyntaxNode>(nodes);
            }

            public override void Visit(SyntaxNode node)
            {
                if (node.IsMissing)
                {
                    throw new SyntaxErrorException();
                }
                base.Visit(node);
            }

            public override void DefaultVisit(SyntaxNode node)
            {
                if (node is ExpressionSyntax || node is VariableDeclarationSyntax)
                {
                    _currentBlock.Nodes.Add(node as CSharpSyntaxNode);
                    return;
                }
                throw new SyntaxErrorException("Unsupported syntax: " + node);
            }

            // The following overrides should cover all syntax nodes that inherit from StatementSyntax

            public override void VisitBlock(BlockSyntax node)
            {
                foreach (var statement in node.Statements.Reverse())
                {
                    _nextNodes.Push(statement);
                }
            }

            public override void VisitBreakStatement(BreakStatementSyntax node)
            {
                var remainderBlock = new BasicBlock(_currentBlock.Terminator);
                if (_breakBlock == null)
                {
                    throw new SyntaxErrorException("Break without enclosing loop or switch encountered");
                }
                _currentBlock.Terminator = new JumpTerminator(_breakBlock);
                _currentBlock = remainderBlock;
            }

            public override void VisitCheckedStatement(CheckedStatementSyntax node)
            {
                base.VisitCheckedStatement(node);
            }

            public override void VisitContinueStatement(ContinueStatementSyntax node)
            {
                var remainderBlock = new BasicBlock(_currentBlock.Terminator);
                if (_continueBlock == null)
                {
                    throw new SyntaxErrorException("Continue without enclosing loop or switch encountered");
                }
                _currentBlock.Terminator = new JumpTerminator(_continueBlock);
                _currentBlock = remainderBlock;
            }

            public override void VisitDoStatement(DoStatementSyntax node)
            {
                var remainderBlock = new BasicBlock(_currentBlock.Terminator);
                var loopBodyBlock = new BasicBlock(null);
                var loopHeaderBlock = new BasicBlock(new BranchTerminator(node.Condition, loopBodyBlock, remainderBlock));
                loopBodyBlock.Terminator = new JumpTerminator(loopHeaderBlock);
                _currentBlock.Terminator = new JumpTerminator(loopBodyBlock);
                _currentBlock = remainderBlock; // The rest of the current block continues in the remainder
                _workQueue.Enqueue(Tuple.Create(CreateNodeStack(node.Statement), loopBodyBlock, loopHeaderBlock, remainderBlock));
            }

            public override void VisitEmptyStatement(EmptyStatementSyntax node)
            {
                _currentBlock.Nodes.Add(node);
            }

            public override void VisitExpressionStatement(ExpressionStatementSyntax node)
            {
                _currentBlock.Nodes.Add(node);
            }

            public override void VisitFixedStatement(FixedStatementSyntax node)
            {
                base.VisitFixedStatement(node);
            }

            public override void VisitForEachStatement(ForEachStatementSyntax node)
            {
                base.VisitForEachStatement(node);
            }

            public override void VisitForStatement(ForStatementSyntax node)
            {
                var remainderBlock = new BasicBlock(_currentBlock.Terminator);
                var forBodyBlock = new BasicBlock(null);
                var forConditionBlock = new BasicBlock(new BranchTerminator(node.Condition, forBodyBlock, remainderBlock));
                var forIteratorBlock = new BasicBlock(new JumpTerminator(forConditionBlock));
                forBodyBlock.Terminator = new JumpTerminator(forIteratorBlock);
                var forInitializerBlock = new BasicBlock(new JumpTerminator(forConditionBlock));
                _currentBlock.Terminator = new JumpTerminator(forInitializerBlock);
                _currentBlock = remainderBlock; // The rest of the current block continues in the remainder
                // A for initializer has either a variable declaration or a list of expressions
                if (node.Declaration != null)
                {
                    _workQueue.Enqueue(Tuple.Create(CreateNodeStack(node.Declaration), forInitializerBlock, _continueBlock, _breakBlock));
                }
                else
                {
                    _workQueue.Enqueue(Tuple.Create(CreateNodeStack(node.Initializers.ToArray()), forInitializerBlock, _continueBlock, _breakBlock));
                }
                _workQueue.Enqueue(Tuple.Create(CreateNodeStack(node.Incrementors.ToArray()), forIteratorBlock, _continueBlock, _breakBlock));
                _workQueue.Enqueue(Tuple.Create(CreateNodeStack(node.Statement), forBodyBlock, forIteratorBlock, remainderBlock));
            }

            public override void VisitGlobalStatement(GlobalStatementSyntax node)
            {
                base.VisitGlobalStatement(node);
            }

            public override void VisitGotoStatement(GotoStatementSyntax node)
            {
                var remainderBlock = new BasicBlock(_currentBlock.Terminator);
                var targetLabelSymbol = (ILabelSymbol)_model.GetSymbolInfo(node.Expression).Symbol;
                var targetBlock = _labels.GetOrCreate(targetLabelSymbol, () => new BasicBlock(null));
                _currentBlock.Terminator = new JumpTerminator(targetBlock);
                _currentBlock = remainderBlock; // The rest of the current block continues in the remainder
            }

            public override void VisitIfStatement(IfStatementSyntax node)
            {
                var remainderBlock = new BasicBlock(_currentBlock.Terminator);
                var thenBlock = new BasicBlock(new JumpTerminator(remainderBlock));
                _workQueue.Enqueue(Tuple.Create(CreateNodeStack(node.Statement), thenBlock, _continueBlock, _breakBlock));
                BasicBlock elseBlock = remainderBlock;
                if (node.Else != null)
                {
                    elseBlock = new BasicBlock(new JumpTerminator(remainderBlock));
                    _workQueue.Enqueue(Tuple.Create(CreateNodeStack(node.Else.Statement), elseBlock, _continueBlock, _breakBlock));
                }
                _currentBlock.Terminator = new BranchTerminator(node.Condition, thenBlock, elseBlock);
                _currentBlock = remainderBlock; // The rest of the current block continues in the remainder
            }

            public override void VisitLabeledStatement(LabeledStatementSyntax node)
            {
                var labelSymbol = _model.GetDeclaredSymbol(node);
                var remainderBlock = _labels.GetOrCreate(labelSymbol, () => new BasicBlock(null));
                remainderBlock.Terminator = _currentBlock.Terminator;
                _currentBlock.Terminator = new JumpTerminator(remainderBlock);
                _nextNodes.Push(node.Statement);
                _currentBlock = remainderBlock;
            }

            public override void VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
            {
                _currentBlock.Nodes.Add(node);
            }

            public override void VisitLockStatement(LockStatementSyntax node)
            {
                base.VisitLockStatement(node);
            }

            public override void VisitReturnStatement(ReturnStatementSyntax node)
            {
                var remainderBlock = new BasicBlock(_currentBlock.Terminator);
                _currentBlock.Terminator = new ReturnTerminator(node.Expression);
                _currentBlock = remainderBlock;
            }

            public override void VisitSwitchStatement(SwitchStatementSyntax node)
            {
                var remainderBlock = new BasicBlock(_currentBlock.Terminator);
                var cases = new List<SwitchTerminator.Case>();
                foreach (var section in node.Sections)
                {
                    var caseBlock = new BasicBlock(new JumpTerminator(remainderBlock));
                    _workQueue.Enqueue(Tuple.Create(CreateNodeStack(section.Statements.ToArray()), caseBlock, _continueBlock, remainderBlock));

                    var labels = new List<ExpressionSyntax>();
                    bool isDefault = false;
                    foreach (var label in section.Labels)
                    {
                        if (label is DefaultSwitchLabelSyntax)
                        {
                            isDefault = true;
                        }
                        else if (label is CaseSwitchLabelSyntax)
                        {
                            labels.Add(((label as CaseSwitchLabelSyntax)).Value);
                        }
                    }
                    cases.Add(new SwitchTerminator.Case(labels.ToArray(), section.Statements.ToArray(), isDefault));
                }
                _currentBlock.Terminator = new SwitchTerminator(cases.ToArray());
                _currentBlock = remainderBlock; // The rest of the current block continues in the remainder
            }

            public override void VisitThrowStatement(ThrowStatementSyntax node)
            {
                var remainderBlock = new BasicBlock(_currentBlock.Terminator);
                _currentBlock.Terminator = new ThrowTerminator(node.Expression);
                _currentBlock = remainderBlock;
            }

            public override void VisitTryStatement(TryStatementSyntax node)
            {
                base.VisitTryStatement(node);
            }

            public override void VisitUnsafeStatement(UnsafeStatementSyntax node)
            {
                base.VisitUnsafeStatement(node);
            }

            public override void VisitUsingStatement(UsingStatementSyntax node)
            {
                base.VisitUsingStatement(node);
            }

            public override void VisitWhileStatement(WhileStatementSyntax node)
            {
                var remainderBlock = new BasicBlock(_currentBlock.Terminator);
                var loopBodyBlock = new BasicBlock(null);
                var loopHeaderBlock = new BasicBlock(new BranchTerminator(node.Condition, loopBodyBlock, remainderBlock));
                loopBodyBlock.Terminator = new JumpTerminator(loopHeaderBlock);
                _currentBlock.Terminator = new JumpTerminator(loopHeaderBlock);
                _currentBlock = remainderBlock; // The rest of the current block continues in the remainder
                _workQueue.Enqueue(Tuple.Create(CreateNodeStack(node.Statement), loopBodyBlock, loopHeaderBlock, remainderBlock));
            }

            public override void VisitYieldStatement(YieldStatementSyntax node)
            {
                switch (node.Kind())
                {
                    case SyntaxKind.YieldReturnStatement:
                        _currentBlock.Nodes.Add(node);
                        break;
                    case SyntaxKind.YieldBreakStatement:
                        var remainderBlock = new BasicBlock(_currentBlock.Terminator);
                        _currentBlock.Terminator = new YieldBreakTerminator();
                        _currentBlock = remainderBlock;
                        break;
                    default:
                        base.VisitYieldStatement(node);
                        break;
                }
            }
        }
    }
}
