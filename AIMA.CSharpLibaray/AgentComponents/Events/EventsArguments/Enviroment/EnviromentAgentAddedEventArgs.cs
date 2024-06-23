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
    public partial class EnviromentAgentAddedEventArgs<TAgent, TPrecept, TAction> : BaseEnviromentEventArgs<TAgent, TPrecept, TAction>
        where TAction : BaseAction, new()
        where TPrecept : BasePrecept, new()
        where TAgent : BaseAgent<TPrecept, TAction>, new()
    {
        #region cstor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentAdded"></param>
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
