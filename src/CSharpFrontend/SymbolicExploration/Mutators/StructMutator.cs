using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.SymbolicExploration.Mutators
{
    class StructMutator : Mutator<StructSortMapping, TupleSort>
    {
        readonly ReadOnlyCollection<Mutator> _fieldMutators;

        /// <summary>
        /// This constructor takes ownership of the fieldMutators array passed in.
        /// </summary>
        public StructMutator(StructSortMapping sortMapping, IEnumerable<Mutator> fieldMutators)
            : base(sortMapping)
        {
            _fieldMutators = Array.AsReadOnly(fieldMutators.ToArray());
        }

        public override Expr CreateUpdate()
        {
            // Construct the update from the individual fields' updates
            var fieldExprs = _fieldMutators.Select(v => v.CreateUpdate());
            return Sort.MkDecl.Apply(fieldExprs.ToArray());
        }

        /// <summary>
        /// Return a new instance with the assignment applied. Unchanged field reuse the existing <see cref="Mutator"/> instances.
        /// </summary>
        /// <param name="accessor"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override Mutator WithAssignment(FieldAccessor accessor, Mutator value)
        {
            var newMutators = _sortMapping.FieldSymbols.Zip(_fieldMutators, (Symbol, Mutator) => new { Symbol, Mutator }).Select(x =>
            {
                if (x.Symbol == accessor.Symbol)
                {
                    return x.Mutator.WithAssignment(accessor.Next, value);
                }
                else
                {
                    return x.Mutator;
                }
            });
            return new StructMutator(_sortMapping, newMutators);
        }

        public override Mutator Extract(FieldAccessor accessor)
        {
            // Dispatch the accessor on to the field mutator
            return _sortMapping.FieldSymbols.Zip(_fieldMutators, (Symbol, Mutator) => new { Symbol, Mutator })
                .First(x => x.Symbol == accessor.Symbol).Mutator.Extract(accessor.Next);
        }
    }
}
