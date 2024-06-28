using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Agent.Base.ProblemSolving
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>

    public abstract partial class BaseSimpleProblemSolvingAgent< TPrecept, TState, TAction> : BaseAgent< TPrecept, TAction>
        where TAction : BaseAction, new()
        where TPrecept : BasePrecept, new()
        
    {
        /// <summary>
        /// 
        /// </summary>
        protected BaseSimpleProblemSolvingAgent() : base()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentProgram"></param>
        /// <param name="isAlive"></param>
        /// <param name="performanceMetricStructure"></param>
        protected BaseSimpleProblemSolvingAgent(
            BaseAgentProgram< TPrecept, TAction> agentProgram,
            IPerformanceMeasure performanceMetricStructure,
            bool isAlive) : base(agentProgram, performanceMetricStructure, isAlive)
        {
        }
    }
}
