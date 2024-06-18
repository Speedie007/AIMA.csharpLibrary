namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TAction"></typeparam>
    public partial class Rule<TAction> : IEquatable<Rule<TAction>?>
    {
        /// <summary>
        /// 
        /// </summary>
        public Condition RuleCondition { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public TAction RequiredAction { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="action"></param>
        public Rule(Condition condition, TAction action)
        {
            //assert(null != con);

            RuleCondition = condition;
            RequiredAction = action;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return Equals(obj as Rule<TAction>);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Rule<TAction>? other)
        {
            return other is not null &&
                   EqualityComparer<Condition>.Default.Equals(RuleCondition, other.RuleCondition) &&
                   EqualityComparer<TAction>.Default.Equals(RequiredAction, other.RequiredAction);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(RuleCondition, RequiredAction);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return "if " + RuleCondition + " then " + RequiredAction + ".";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(Rule<TAction>? left, Rule<TAction>? right)
        {
            return EqualityComparer<Rule<TAction>>.Default.Equals(left, right);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(Rule<TAction>? left, Rule<TAction>? right)
        {
            return !(left == right);
        }
    }
}
