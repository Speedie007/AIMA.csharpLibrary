using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Agent;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.PerformanceMeasure;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Agent.Interface
{
    /// <summary>
    ///<para>
    ///Author:Ciaran O'Reilly
    ///</para>
    ///<para>
    ///Author:Ruediger Lunde
    ///</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 11 May 2024 - Date Last Updated: 18 June 2024</para>
    /// </summary>
    public partial interface IAgentEventFeedBack<TPerformanceMeasure,TPrecept, TAction>
        where TPrecept : BasePrecept, new()
        where TAction : BaseAction, new()
         where TPerformanceMeasure: BasePerformanceMeasure, new() 
    {
        /// <summary>
        ///  A simple notification message, to be forwarded to someone.
        /// </summary>
        /// <param name="agentNotificationEventArgs">The message to be forwarded from the current Environment.</param>
        void OnAgentMessageNotification(AgentNotificationEventArgs<TPerformanceMeasure, TPrecept, TAction> agentNotificationEventArgs);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentPerformanceMeasureUpdatedEventArgs"></param>
        void OnAgentPerformanceMeasureUpdated(AgentPerformanceMeasureUpdatedEventArgs<TPerformanceMeasure,TPrecept, TAction> agentPerformanceMeasureUpdatedEventArgs);


    }
}
