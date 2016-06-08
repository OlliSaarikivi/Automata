using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Automata.CSharpFrontend.CodeGeneration;
using Microsoft.Automata.CSharpFrontend.SymbolicExploration;
using Microsoft.Automata.CSharpFrontend.SymbolicExploration.Mutators;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend
{
    class StructSortMapping : SortMapping<TupleSort>
    {
        public INamedTypeSymbol Symbol { get; private set; }
        public IFieldSymbol[] FieldSymbols { get; private set; }
        public SortMapping[] FieldSortMappings { get; private set; }

        public StructSortMapping(CompilationInfo info, INamedTypeSymbol symbol)
            : base(info)
        {
            Symbol = symbol;
            // The order of the following array fixes the order of the fields in the tuple
            FieldSymbols = Symbol.GetMembers().OfType<IFieldSymbol>().ToArray();
            if (!FieldSymbols.All(s => !s.IsStatic))
            {
                throw new SyntaxErrorException("Static fields are not supported");
            }
            // Get the sort mappings for the fields
            var fieldInfo = FieldSymbols.Select(s => new { Symbol = s, Mapping = Mapper.GetSortMapping(s.Type) });
            // Create the tuplesort with the fields' sorts
            Sort = Ctx.MkTupleSort(Mapper.CreateZ3Symbol(Symbol),
                fieldInfo.Select(x => Mapper.CreateZ3Symbol(x.Symbol)).ToArray(),
                fieldInfo.Select(x => x.Mapping.Sort).ToArray());
            FieldSortMappings = fieldInfo.Select(x => x.Mapping).ToArray();
            Mapper.RegisterStructSortMapping(this);
        }

        public override Mutator MutatorForValue(Expr initialValue)
        {
            Contract.Requires(initialValue.Sort == Sort);
            // Apply the projections to create the initial values of the fields
            var fieldExprs = Sort.FieldDecls.Select(f => f.Apply(initialValue));
            var fieldMutators = FieldSortMappings.Zip(fieldExprs, (SortMapping, FieldExpr) => SortMapping.MutatorForValue(FieldExpr));
            return new StructMutator(this, fieldMutators);
        }

        public override Mutator MutatorForDefaultValue()
        {
            // The declaration of the struct is processed to find any field initializations. Fields get their initial values from
            // the declaration, or if no initial value is declared then the default value for the type is used.
            var fieldMutators = new List<Mutator>();
            var evaluator = new DefaultValueEvaluator(_info);
            foreach (var field in FieldSymbols.Zip(FieldSortMappings, (Symbol, SortMapping) => new { Symbol, SortMapping }))
            {
                Mutator fieldMutator;
                var declarations = field.Symbol.DeclaringSyntaxReferences.Select(r => r.GetSyntax()).OfType<VariableDeclaratorSyntax>().ToList();

                if (declarations.Count > 1)
                {
                    throw new SyntaxErrorException("Multiple declarations found for " + field + " in " + Symbol);
                }
                else if (declarations.Count == 0)
                {
                    throw new SyntaxErrorException("Declaration of field " + field + " in " + Symbol + " not found");
                }
                var declaration = declarations[0];
                if (declaration.Initializer != null)
                {
                    fieldMutator = evaluator.Visit(declaration.Initializer) as Mutator;
                    if (fieldMutator == null)
                    {
                        throw new SyntaxErrorException("Unsupported syntax: " + declaration);
                    }
                }
                else
                {
                    fieldMutator = field.SortMapping.MutatorForDefaultValue();
                }
                fieldMutators.Add(fieldMutator);
            }
            return new StructMutator(this, fieldMutators);
        }

        /// <summary>
        /// Implements an expression evaluator with no support for accessing other variables. Because static variables are not supported this is enough.
        /// </summary>
        class DefaultValueEvaluator : ExpressionEvaluator
        {
            public DefaultValueEvaluator(CompilationInfo info)
                : base(info)
            {
            }

            public override AccessorOrMutator VisitEqualsValueClause(EqualsValueClauseSyntax node)
            {
                return Visit(node.Value);
            }

            public override Mutator WithAssignment(FieldAccessor accessor, Mutator value)
            {
                throw new SyntaxErrorException("Assignments inside variable declarations are unsupported");
            }

            public override Mutator WithAssignment(LocalAccessor accessor, Mutator value)
            {
                throw new SyntaxErrorException("Assignments inside variable declarations are unsupported");
            }

            public override Mutator WithAssignment(ParameterAccessor accessor, Mutator value)
            {
                throw new SyntaxErrorException("Assignments inside variable declarations are unsupported");
            }

            public override Mutator Extract(FieldAccessor accessor)
            {
                throw new SyntaxErrorException("Can not access instance inside variable declaration");
            }

            public override Mutator Extract(LocalAccessor accessor)
            {
                throw new SyntaxErrorException("Can not access instance inside variable declaration");
            }

            public override Mutator Extract(ParameterAccessor accessor)
            {
                throw new SyntaxErrorException("Can not access instance inside variable declaration");
            }
        }
    }
}
