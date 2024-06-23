using AIMA.CSharpLibrary.AgentComponents.State.Base;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules.Interfaces
{
    /// <summary>
    /// 21 June 2024
    /// </summary>
    public partial interface ICondition
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="state"></param>
        /// <returns></returns>
        bool Validate<TState>(TState state) where TState : BaseState;
    }
}