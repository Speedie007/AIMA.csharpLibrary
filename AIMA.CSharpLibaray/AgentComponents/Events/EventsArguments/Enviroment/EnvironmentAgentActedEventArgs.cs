using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Environment.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Environment
{
    /// <summary>
    /// 16 June
    /// </summary>
    /// <typeparam name="TAgent"></typeparam>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    /// <typeparam name="TPerformanceMeasure"></typeparam>
    public partial class EnvironmentAgentActedEventArgs<TPerformanceMeasure, TAgent, TPrecept, TAction> : 
        BaseEnvironmentEventArgs<TPerformanceMeasure,TAgent, TPrecept, TAction>
        where TAction : BaseAction, new()
        where TPrecept : BasePrecept, new()
         where TPerformanceMeasure: BasePerformanceMeasure, new() 
        where TAgent : BaseAgent<TPerformanceMeasure, TPrecept, TAction>, new()
    {
        #region cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="currentPercept"></param>
        /// <param name="actionExecuted"></param>
        /// <param name="sourceEnvironment"></param>
        public EnvironmentAgentActedEventArgs(
            TAgent agent,
            TPrecept currentPercept,
            TAction actionExecuted,
            BaseEnvironment<TPerformanceMeasure,TAgent, TPrecept, TAction> sourceEnvironment) : base(sourceEnvironment)
        {
            Agent = agent;
            CurrentPercept = currentPercept;
            ActionExecuted = actionExecuted;
        }
        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public TAgent Agent { get; }
        /// <summary>
        /// 
        /// </summary>
        public TPrecept CurrentPercept { get; }
        /// <summary>
        /// 
        /// </summary>
        public TAction ActionExecuted { get; }
        #endregion
    }
}
