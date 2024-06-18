using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Enviroment;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface
{
    /// <summary>
    /// Allows applications to analyze and visualize the interaction of BaseAgent(s) with an Environment.
    ///<para>
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 12 May 2024 - Date Last Updated: 16 June 2024</para>
    /// </summary>
    /// <typeparam name="TAgent">Base Type which is used to represent the Agent</typeparam>
    /// <typeparam name="TPrecept">Base Type which is used to represent Percepts</typeparam>
    /// <typeparam name="TAction">Base Type which is used to represent Actions</typeparam>
    public partial interface IEnviromentEventFeedBack<TAgent, TPrecept, TAction>
        where TAction : BaseAction, new()
        where TPrecept : BasePrecept, new()
        where TAgent : BaseAgent<TPrecept, TAction>

    {

        /// <summary>
        /// Will raise the OnAgentAdded Event delegate which will multi cast to all subscribed listners the agent that was added to the enviroment.
        /// </summary>
        /// <remarks>
        /// Note: The Event Delegate is in the BaseEnviroment Class
        /// </remarks>
        /// <param name="args">
        /// The args parameter will retun the Agent that was added the Precept if applicable and the acction if applicable
        /// </param>
        void OnAgentAdded(EnviromentAgentAddedEventArgs<TAgent, TPrecept, TAction> args);
        /// <summary>
        /// Will raise the OnAgentRemoved Event delegate which will multi cast to all subscribed listners the agent that was removed from the enviroment.
        /// </summary>
        /// <remarks>
        /// Note: The Event Delegate is in the BaseEnviroment Class
        /// </remarks>
        /// <param name="args">
        /// The args parameter will retun the Agent that was added the Precept if applicable and the acction if applicable
        /// </param>
        void OnAgentRemoved(EnviromentAgentRemovedEventArgs<TAgent, TPrecept, TAction> args);
        /// <summary>
        /// Will raise the OnAgentActed Event delegate which will multi cast to all subscribed listners the agent is executing and acting in the enviroment.
        /// </summary>
        /// <remarks>
        /// Note: The Event Delegate is in the BaseEnviroment Class
        /// </remarks>
        /// <param name="args">
        /// The args parameter will retun the Agent which perform the action the Precept current observed and the ActionExecuted which initiaed the action.
        /// </param>
        void OnAgentActed(EnviromentAgentActedEventArgs<TAgent, TPrecept, TAction> args);

    }
}
