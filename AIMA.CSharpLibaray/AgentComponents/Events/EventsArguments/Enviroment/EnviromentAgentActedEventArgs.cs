using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Enviroment
{
    /// <summary>
    /// 16 june
    /// </summary>
    /// <typeparam name="TAgent"></typeparam>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial class EnviromentAgentActedEventArgs<TAgent, TPrecept, TAction> : BaseEnviromentEventArgs<TAgent, TPrecept, TAction>
        where TAction : BaseAction, new()
        where TPrecept : BasePrecept, new()
        where TAgent : BaseAgent<TPrecept, TAction>, new()
    {
        #region cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="currentPercept"></param>
        /// <param name="actionExecuted"></param>
        /// <param name="sourceEnviroment"></param>
        public EnviromentAgentActedEventArgs(
            TAgent agent,
            TPrecept currentPercept,
            TAction actionExecuted,
            BaseEnvironment<TAgent, TPrecept, TAction> sourceEnviroment) : base(sourceEnviroment)
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
