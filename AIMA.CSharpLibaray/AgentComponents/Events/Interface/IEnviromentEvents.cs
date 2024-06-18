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
            where TAgent : BaseAgent<TPrecept, TAction>
    {
        /// <summary>
        /// 
        /// </summary>
        event EnviromentEventHandlers<TAgent, TPrecept, TAction>.AgentAddedEventHandler AgentAdded;
        /// <summary>
        /// 
        /// </summary>
        event EnviromentEventHandlers<TAgent, TPrecept, TAction>.AgentActedEventHandler AgentActed;
        /// <summary>
        /// 
        /// </summary>
        event EnviromentEventHandlers<TAgent, TPrecept, TAction>.AgentRemovedEventHandler AgentRemoved;
    }
}
