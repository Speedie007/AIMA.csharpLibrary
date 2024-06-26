﻿using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.Interface
{
    /// <summary>
    /// 16 June
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    
    public partial interface IAgentEvents< TPrecept, TAction>
        where TPrecept : BasePrecept, new()
        where TAction : BaseAction, new()
          
    {

        /// <summary>
        /// 
        /// </summary>
        event PerformanceMeasureEventHandlers.AgentPerformanceMeasureUpdatedEventHandler< TPrecept, TAction> PerformanceMeasureUpdatedEvent;

        /// <summary>
        /// 
        /// </summary>
        event AgentEventHandlers.AgentNotificationEventHandler< TPrecept, TAction> AgentNotificationEvent;

    }
}
