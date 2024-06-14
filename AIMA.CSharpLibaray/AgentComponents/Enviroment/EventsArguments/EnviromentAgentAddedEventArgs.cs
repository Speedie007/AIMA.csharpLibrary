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
    public partial class EnviromentAgentAddedEventArgs<TAgent, TPrecept, TAction> : BaseEnviromentEvent<TAgent, TPrecept, TAction>
        where TAction : BaseAgentAction, new()
        where TPrecept : BaseAgentPrecept, new()
        where TAgent : BaseAgent<TPrecept, TAction>
    {
        #region cstor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="sourceEnviroment"></param>
        public EnviromentAgentAddedEventArgs(
            TAgent agentAdded,
            BaseEnvironment<TAgent, TPrecept, TAction> sourceEnviroment) : base(sourceEnviroment)
        {
            AgentAdded = agentAdded;

        }


        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public TAgent AgentAdded { get; }
        #endregion
    }

}
