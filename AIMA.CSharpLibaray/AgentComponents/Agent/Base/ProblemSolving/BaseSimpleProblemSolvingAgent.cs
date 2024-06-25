using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Interface;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Agent.Base.ProblemSolving
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public abstract partial class BaseSimpleProblemSolvingAgent<TPrecept, TState, TAction> : BaseAgent<TPrecept, TAction>
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
        /// <param name="performaceMeasure"></param>
        /// <param name="isAlive"></param>
        protected BaseSimpleProblemSolvingAgent(
            BaseAgentProgram<TPrecept, TAction> agentProgram,
            BasePerformanceMeasure performaceMeasure,
            bool isAlive) : base(agentProgram, performaceMeasure, isAlive)
        {
        }
    }
}
