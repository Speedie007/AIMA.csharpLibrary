using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Enviroment
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <typeparam name="TAgent"><inheritdoc/></typeparam>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial class EnviromentAgentRemovedEventArgs<TAgent, TPrecept, TAction> : BaseEnviromentEventArgs<TAgent, TPrecept, TAction>
        where TAction : BaseAction, new()
        where TPrecept : BasePrecept, new()
        where TAgent : BaseAgent<TPrecept, TAction>, new()  
    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentRemoved"></param>
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
