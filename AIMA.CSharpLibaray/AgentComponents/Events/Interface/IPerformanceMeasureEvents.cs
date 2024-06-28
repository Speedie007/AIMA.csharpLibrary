using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.Interface
{
    /// <summary>
    /// 16June
    /// </summary>
    public partial interface IPerformanceMeasureEvents<TPerformanceMeasure,TPrecept, TAction>
        where TPrecept : BasePrecept, new() 
        where TAction : BaseAction, new()
        where TPerformanceMeasure: BasePerformanceMeasure, new()
    {
        /// <summary>
        /// 
        /// </summary>
        event PerformanceMeasureEventHandlers.AgentPerformanceMeasureUpdatedEventHandler<TPerformanceMeasure,TPrecept, TAction> AgentPerformanceMeasureUpdated;
    }
}
