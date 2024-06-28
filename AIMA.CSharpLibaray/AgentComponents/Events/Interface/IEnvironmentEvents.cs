using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.Interface
{
    /// <summary>
    /// 16 June
    /// </summary>
    /// <typeparam name="TAgent"></typeparam>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    
    public partial interface IEnvironmentEvents< TAgent, TPrecept, TAction>
            where TAction : BaseAction, new()
            where TPrecept : BasePrecept, new()
              
            where TAgent : BaseAgent< TPrecept, TAction>, new()
    {
        /// <summary>
        /// 
        /// </summary>
        event EnvironmentEventHandlers.AgentAddedEventHandler< TAgent, TPrecept, TAction> AgentAddedEvent;
        /// <summary>
        /// 
        /// </summary>
        event EnvironmentEventHandlers.AgentActedEventHandler< TAgent, TPrecept, TAction> AgentActedEvent;
        /// <summary>
        /// 
        /// </summary>
        event EnvironmentEventHandlers.AgentRemovedEventHandler< TAgent, TPrecept, TAction> AgentRemovedEvent;
    }
}
