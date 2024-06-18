using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Enviroment;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events
{
    /// <summary>
    ///<para>Defines the required event Handlers for the Agent Enviroment</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 9 June 2024 - Date Last Updated: 16 June 2024</para>
    /// </summary>
    /// <typeparam name="TAgent"></typeparam>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public static class EnviromentEventHandlers<TAgent, TPrecept, TAction>
            where TAction : BaseAction, new()
            where TPrecept : BasePrecept, new()
            where TAgent : BaseAgent<TPrecept, TAction>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="AgentAddedEventArgs"></param>
        public delegate void AgentAddedEventHandler(EnviromentAgentAddedEventArgs<TAgent, TPrecept, TAction> AgentAddedEventArgs);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="AgentRemovedArgs"></param>
        public delegate void AgentRemovedEventHandler(EnviromentAgentRemovedEventArgs<TAgent, TPrecept, TAction> AgentRemovedArgs);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="AgentActedEventArgs"></param>
        public delegate void AgentActedEventHandler(EnviromentAgentActedEventArgs<TAgent, TPrecept, TAction> AgentActedEventArgs);
    }
}
