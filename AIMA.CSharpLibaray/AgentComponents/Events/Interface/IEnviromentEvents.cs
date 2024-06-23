using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.Interface
{
    /// <summary>
    /// 16 june
    /// </summary>
    /// <typeparam name="TAgent"></typeparam>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial interface IEnviromentEvents<TAgent, TPrecept, TAction>
            where TAction : BaseAction, new()
            where TPrecept : BasePrecept, new()
            where TAgent : BaseAgent<TPrecept, TAction>, new()
    {
        /// <summary>
        /// 
        /// </summary>
        event EnviromentEventHandlers.AgentAddedEventHandler<TAgent, TPrecept, TAction> AgentAdded;
        /// <summary>
        /// 
        /// </summary>
        event EnviromentEventHandlers.AgentActedEventHandler<TAgent, TPrecept, TAction> AgentActed;
        /// <summary>
        /// 
        /// </summary>
        event EnviromentEventHandlers.AgentRemovedEventHandler<TAgent, TPrecept, TAction> AgentRemoved;
    }
}
