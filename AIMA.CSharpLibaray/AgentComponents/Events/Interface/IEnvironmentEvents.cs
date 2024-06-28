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
    /// <typeparam name="TPerformanceMeasure"></typeparam>
    public partial interface IEnvironmentEvents<TPerformanceMeasure, TAgent, TPrecept, TAction>
            where TAction : BaseAction, new()
            where TPrecept : BasePrecept, new()
             where TPerformanceMeasure: BasePerformanceMeasure, new() 
            where TAgent : BaseAgent<TPerformanceMeasure, TPrecept, TAction>, new()
    {
        /// <summary>
        /// 
        /// </summary>
        event EnvironmentEventHandlers.AgentAddedEventHandler<TPerformanceMeasure, TAgent, TPrecept, TAction> AgentAddedEvent;
        /// <summary>
        /// 
        /// </summary>
        event EnvironmentEventHandlers.AgentActedEventHandler<TPerformanceMeasure, TAgent, TPrecept, TAction> AgentActedEvent;
        /// <summary>
        /// 
        /// </summary>
        event EnvironmentEventHandlers.AgentRemovedEventHandler<TPerformanceMeasure, TAgent, TPrecept, TAction> AgentRemovedEvent;
    }
}
