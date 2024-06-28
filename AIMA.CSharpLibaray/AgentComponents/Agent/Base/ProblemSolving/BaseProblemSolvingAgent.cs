using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Agent.Base.ProblemSolving
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <typeparam name="TPrecept"><inheritdoc/><inheritdoc/></typeparam>
    /// <typeparam name="TStates"><inheritdoc/></typeparam>
    /// <typeparam name="TAction"><inheritdoc/></typeparam>
    /// <typeparam name="TPerformanceMeasure"></typeparam>
    public abstract partial class BaseProblemSolvingAgent<TPerformanceMeasure, TPrecept, TStates, TAction> :
        BaseAgent<TPerformanceMeasure, TPrecept, TAction>
        where TAction : BaseAction, new()
         where TPrecept : BasePrecept, new()
        where TPerformanceMeasure: BasePerformanceMeasure, new()
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="agentProgram"><inheritdoc/></param>
        /// <param name="isAlive"><inheritdoc/></param>
        /// <param name="performanceMetricStructure"></param>
        protected BaseProblemSolvingAgent(
            BaseAgentProgram<TPerformanceMeasure, TPrecept, TAction> agentProgram,
            TPerformanceMeasure performanceMetricStructure,
            bool isAlive) : base(agentProgram, performanceMetricStructure, isAlive)
        {
        }
    }
}
