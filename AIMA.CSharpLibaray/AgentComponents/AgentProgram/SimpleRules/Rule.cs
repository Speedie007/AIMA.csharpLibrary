using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules
{
    public partial class Rule<TAction> : IEquatable<Rule<TAction>?>
    {
        public Condition RuleCondition { get; private set; }
        public TAction RequiredAction { get; private set; }
        public Rule(Condition condition, TAction action)
        {
            //assert(null != con);

            RuleCondition = condition;
            RequiredAction = action;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Rule<TAction>);
        }

        public bool Equals(Rule<TAction>? other)
        {
            return other is not null &&
                   EqualityComparer<Condition>.Default.Equals(RuleCondition, other.RuleCondition) &&
                   EqualityComparer<TAction>.Default.Equals(RequiredAction, other.RequiredAction);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(RuleCondition, RequiredAction);
        }

        public override string? ToString()
        {
            return "if " + RuleCondition + " then " + RequiredAction + ".";
        }

        public static bool operator ==(Rule<TAction>? left, Rule<TAction>? right)
        {
            return EqualityComparer<Rule<TAction>>.Default.Equals(left, right);
        }

        public static bool operator !=(Rule<TAction>? left, Rule<TAction>? right)
        {
            return !(left == right);
        }
    }
}
