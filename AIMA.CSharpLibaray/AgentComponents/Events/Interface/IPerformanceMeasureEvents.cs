using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.Interface
{
    /// <summary>
    /// 16June
    /// </summary>
    public partial interface IPerformanceMeasureEvents<TPrecept, TAction>
        where TPrecept : BasePrecept, new() where TAction : BaseAction, new()
    {
        /// <summary>
        /// 
        /// </summary>
        event PerformanceMeasureEventHandlers.AgentPerformanceMeasureUpdatedEventHandler<TPrecept, TAction> AgentPerformanceMeasureUpdated;
    }
}
