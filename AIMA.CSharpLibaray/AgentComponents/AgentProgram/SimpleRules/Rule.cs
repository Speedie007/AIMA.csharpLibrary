using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules.Interfaces;
using AIMA.CSharpLibrary.AgentComponents.State.Base;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules
{
    /// <summary>
    /// 21 June 2024
    /// </summary>
    /// <typeparam name="TAction"></typeparam>
    public partial class Rule<TAction> : IEquatable<Rule<TAction>?>, IRule<TAction>
        where TAction : BaseAction, new()
    {
        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public BaseCondition RuleCondition { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public TAction ResultantAction { get; private set; }
        #endregion

        #region Cstor
        /// <summary>
        /// Will creates default rule where the default action is NoOperation(perform no Action).
        /// </summary>
        public Rule() : this(new EMPTYCondition(), new())
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="action"></param>
        public Rule(BaseCondition condition, TAction action)
        {
            RuleCondition = condition;
            ResultantAction = action;
        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool EvaluateRule<TState>(TState state) where TState : BaseState
        {
            return RuleCondition.Validate(state);
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
                   EqualityComparer<BaseCondition>.Default.Equals(RuleCondition, other.RuleCondition) &&
                   EqualityComparer<TAction>.Default.Equals(ResultantAction, other.ResultantAction);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(RuleCondition, ResultantAction);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return $"If {RuleCondition.ToString} Then {ResultantAction.ToString}.";
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
        #endregion
    }
}
