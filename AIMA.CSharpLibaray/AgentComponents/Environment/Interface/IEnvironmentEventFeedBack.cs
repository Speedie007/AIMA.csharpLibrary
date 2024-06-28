using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Environment;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Environment.Interface
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
    
    public partial interface IEnvironmentEventFeedBack<TAgent, TPrecept, TAction>
        where TAction : BaseAction, new()
        where TPrecept : BasePrecept, new()
         
        where TAgent : BaseAgent<TPrecept, TAction>, new()

    {

        /// <summary>
        /// Will raise the OnAgentAdded Event delegate which will multi cast to all subscribed listeners the agent that was added to the Environment.
        /// </summary>
        /// <remarks>
        /// Note: The Event Delegate is in the BaseEnvironment Class
        /// </remarks>
        /// <param name="args">
        /// The args parameter will return the Agent that was added the Precept if applicable and the action if applicable
        /// </param>
        void OnAgentAdded(EnvironmentAgentAddedEventArgs< TAgent, TPrecept, TAction> args);
        /// <summary>
        /// Will raise the OnAgentRemoved Event delegate which will multi cast to all subscribed listeners the agent that was removed from the Environment.
        /// </summary>
        /// <remarks>
        /// Note: The Event Delegate is in the BaseEnvironment Class
        /// </remarks>
        /// <param name="args">
        /// The args parameter will return the Agent that was added the Precept if applicable and the action if applicable
        /// </param>
        void OnAgentRemoved(EnvironmentAgentRemovedEventArgs< TAgent, TPrecept, TAction> args);
        /// <summary>
        /// Will raise the OnAgentActed Event delegate which will multi cast to all subscribed listeners the agent is executing and acting in the Environment.
        /// </summary>
        /// <remarks>
        /// Note: The Event Delegate is in the BaseEnvironment Class
        /// </remarks>
        /// <param name="args">
        /// The args parameter will return the Agent which perform the action the Precept current observed and the ActionExecuted which initiated the action.
        /// </param>
        void OnAgentActed(EnvironmentAgentActedEventArgs< TAgent, TPrecept, TAction> args);

    }
}
