using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Agent;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events
{
    /// <summary>
    ///<para>Defines the required event Handlers for the Agent Enviroment</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 16 June 2024 - Date Last Updated: 16 June 2024</para>
    /// </summary>
    public static class AgentEventHandlers
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TPrecept"></typeparam>
        /// <typeparam name="TAction"></typeparam>
        /// <param name="agentNotificationEventArgs"></param>

        public delegate void AgentNotificationEventHandler<TPrecept, TAction>(AgentNotificationEventArgs<TPrecept, TAction> agentNotificationEventArgs)
            where TPrecept : BasePrecept, new()
            where TAction : BaseAction, new();
    }
}
