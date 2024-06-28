using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Agent.Base.ProblemSolving
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <typeparam name="TPrecept"><inheritdoc/><inheritdoc/></typeparam>
    /// <typeparam name="TStates"><inheritdoc/></typeparam>
    /// <typeparam name="TAction"><inheritdoc/></typeparam>

    public abstract partial class BaseProblemSolvingAgent< TPrecept, TStates, TAction> :
        BaseAgent< TPrecept, TAction>
        where TAction : BaseAction, new()
         where TPrecept : BasePrecept, new()
        
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="agentProgram"><inheritdoc/></param>
        /// <param name="isAlive"><inheritdoc/></param>
        /// <param name="performanceMetricStructure"></param>
        protected BaseProblemSolvingAgent(
            BaseAgentProgram< TPrecept, TAction> agentProgram,
            IPerformanceMeasure performanceMetricStructure,
            bool isAlive) : base(agentProgram, performanceMetricStructure, isAlive)
        {
        }
    }
}
