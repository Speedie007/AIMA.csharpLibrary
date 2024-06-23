using AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules.Base;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules.Interfaces
{
    /// <summary>
    /// 21 June 2024
    /// </summary>
    /// <typeparam name="TAction"></typeparam>
    public interface IRule<TAction>
    {
        /// <summary>
        /// 
        /// </summary>
        TAction ResultantAction { get; }
        /// <summary>
        /// 
        /// </summary>
        BaseCondition RuleCondition { get; }
    }
}