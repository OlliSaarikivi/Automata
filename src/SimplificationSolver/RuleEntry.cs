using Microsoft.Automata.Z3;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.SimplificationSolver
{
    class RuleResult
    {
        public Expr Term { get; set; }
        public int ReinspectDepth { get; set; }

        public RuleResult(Expr term, int reinspectDepth = 1)
        {
            Term = term;
            ReinspectDepth = reinspectDepth;
        }
    }

    class RuleEntry
    {
        public string Name { get; set; }
        public Func<Z3Provider, Expr, Expr, RuleResult> Rule { get; set; }

        public RuleEntry(string name, Func<Z3Provider, Expr, Expr, RuleResult> rule)
        {
            Name = name;
            Rule = rule;
        }
    }
}
