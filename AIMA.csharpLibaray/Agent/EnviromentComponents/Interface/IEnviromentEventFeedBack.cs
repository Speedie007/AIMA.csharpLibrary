using AIMA.csharpLibrary.Agent.AgentComponents.Base;
using AIMA.csharpLibrary.Agent.EnviromentComponents.EventsArguments;

namespace AIMA.csharpLibrary.Agent.EnviromentComponents.Interface
{
    /// <summary>
    /// Allows applications to analyze and visualize the interaction of BaseAgent(s) with an Environment.
    ///<para>
    ///Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 12 May 2024 - Date Last Updated: 12 May 2024</para>
    /// </summary>
    /// <typeparam name="TPrecept">Type which is used to represent percepts</typeparam>
    /// <typeparam name="TAction">ype which is used to represent actions</typeparam>
    public partial interface IEnviromentEventFeedBack<TAgent, TPrecept, TAction>
        where TPrecept : class, new()
        where TAction : class, new()
        where TAgent : BaseAgent<TPrecept, TAction>, new()
    {
        void OnAgentAdded(EnviromentAgentAddedEventArgs<TAgent, TPrecept, TAction> e);

        void OnAgentRemoved(EnviromentAgentRemovedEventArgs<TAgent, TPrecept, TAction> e);

        void OnAgentActed(EnviromentAgentActedEventArgs<TAgent, TPrecept, TAction> e);

    }
}
