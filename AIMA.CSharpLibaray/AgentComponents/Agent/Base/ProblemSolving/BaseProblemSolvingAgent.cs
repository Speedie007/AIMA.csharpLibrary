using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Interface;
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
    public abstract partial class BaseProblemSolvingAgent<TPrecept, TStates, TAction> : BaseAgent<TPrecept, TAction>
        where TAction : BaseAction, new()
         where TPrecept : BasePrecept, new()
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="agentProgram"><inheritdoc/></param>
        /// <param name="performanceMeasure"><inheritdoc/></param>
        /// <param name="isAlive"><inheritdoc/></param>
        protected BaseProblemSolvingAgent(
            BaseAgentProgram<TPrecept, TAction> agentProgram,
            BasePerformanceMeasure performanceMeasure,
            bool isAlive) : base(agentProgram, performanceMeasure, isAlive)
        {
        }
    }
}
