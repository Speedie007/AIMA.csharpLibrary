using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.EventsArguments;
using AIMA.CSharpLibrary.AgentComponents.Precepts;

namespace AIMA.CSharpLibrary.AgentComponents.Enviroment.Events
{
    /// <summary>
    ///<para>Defines the required event Handlers for the Agent Enviroment</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 9 June 2024 - Date Last Updated: 9 June 2024</para>
    /// </summary>
    /// <typeparam name="TAgent"></typeparam>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public static class EnviromentEventHandlers<TAgent, TPrecept, TAction>
            where TAction : BaseAgentAction, new()
            where TPrecept : BaseAgentPrecept, new()
            where TAgent : BaseAgent<TPrecept, TAction>
    {
        public delegate void AgentAddedEventHandler(EnviromentAgentAddedEventArgs<TAgent, TPrecept, TAction> AgentAddedEventArgs);
        public delegate void AgentRemovedEventHandler(EnviromentAgentRemovedEventArgs<TAgent, TPrecept, TAction> AgentRemovedArgs);
        public delegate void AgentActedEventHandler(EnviromentAgentActedEventArgs<TAgent, TPrecept, TAction> AgentActedEventArgs);
    }
}
