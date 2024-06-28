using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.Interface
{
    /// <summary>
    /// 16 June
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    /// <typeparam name="TPerformanceMeasure"></typeparam>
    public partial interface IAgentEvents<TPerformanceMeasure, TPrecept, TAction>
        where TPrecept : BasePrecept, new()
        where TAction : BaseAction, new()
         where TPerformanceMeasure: BasePerformanceMeasure, new() 
    {

        /// <summary>
        /// 
        /// </summary>
        event PerformanceMeasureEventHandlers.AgentPerformanceMeasureUpdatedEventHandler<TPerformanceMeasure, TPrecept, TAction> PerformanceMeasureUpdatedEvent;

        /// <summary>
        /// 
        /// </summary>
        event AgentEventHandlers.AgentNotificationEventHandler<TPerformanceMeasure, TPrecept, TAction> AgentNotificationEvent;

    }
}
