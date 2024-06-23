using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.PerformaneMeasure;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events
{
    /// <summary>
    /// 18 June
    /// </summary>
    public static class PerformanceMeasureEventHandlers
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TPrecept"></typeparam>
        /// <typeparam name="TAction"></typeparam>
        /// <param name="agentPerformanceMeasureUpdatedEventArgs"></param>
        public delegate void AgentPerformanceMeasureUpdatedEventHandler<TPrecept, TAction>(
            AgentPerformanceMeasureUpdatedEventArgs<TPrecept, TAction> agentPerformanceMeasureUpdatedEventArgs)
                where TPrecept : BasePrecept, new() where TAction : BaseAction, new();
    }
}
