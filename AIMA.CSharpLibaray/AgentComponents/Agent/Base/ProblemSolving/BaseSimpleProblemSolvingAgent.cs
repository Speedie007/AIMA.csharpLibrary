using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Agent.Base.ProblemSolving
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    /// <typeparam name="TPerformanceMeasure"></typeparam>
    public abstract partial class BaseSimpleProblemSolvingAgent<TPerformanceMeasure, TPrecept, TState, TAction> : BaseAgent<TPerformanceMeasure, TPrecept, TAction>
        where TAction : BaseAction, new()
        where TPrecept : BasePrecept, new()
        where TPerformanceMeasure: BasePerformanceMeasure, new()
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
            BaseAgentProgram<TPerformanceMeasure, TPrecept, TAction> agentProgram,
            TPerformanceMeasure performanceMetricStructure,
            bool isAlive) : base(agentProgram, performanceMetricStructure, isAlive)
        {
        }
    }
}
