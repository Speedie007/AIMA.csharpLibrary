using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.EventsArguments.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts;

namespace AIMA.CSharpLibrary.AgentComponents.Enviroment.EventsArguments
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial class EnviromentAgentRemovedEventArgs<TAgent, TPrecept, TAction> : BaseEnviromentEvent<TAgent, TPrecept, TAction>
        where TAction : BaseAgentAction, new()
        where TPrecept : BaseAgentPrecept, new()
        where TAgent : BaseAgent<TPrecept, TAction>
    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="sourceEnviroment"></param>
        public EnviromentAgentRemovedEventArgs(TAgent agentRemoved, BaseEnvironment<TAgent, TPrecept, TAction> sourceEnviroment)
            : base(sourceEnviroment)
        {
            AgentRemoved = agentRemoved;
        }
        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public TAgent AgentRemoved { get; }
        #endregion


    }
}
