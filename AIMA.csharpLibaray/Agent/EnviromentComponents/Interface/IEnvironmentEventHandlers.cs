namespace AIMA.csharpLibrary.Agent.EnviromentComponents.Interface
{
    /// <summary>
    /// Allows applications to analyze and visualize the interaction of BaseAgent(s) with an Environment.
    /// </summary>
    ///<para>
    ///Author:Ravi Mohan
    ///</para>
    ///<para>
    ///Author:Ciaran O'Reilly
    ///</para>
    ///<para>
    ///Author:Mike Stampone
    ///</para>
    ///<para>
    ///Author:Ruediger Lunde
    ///</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 10 May 2024 - Date Last Updated: 10 May 2024</para>
    /// <typeparam name="TPrecept">Type which is used to represent percepts</typeparam>
    /// <typeparam name="TAction">ype which is used to represent actions</typeparam>
    public partial interface IEnvironmentEventHandlers<TPrecept, TAction> 
        where TPrecept : class ,new()
        where TAction : class, new()
    {
        delegate void Del(string message);
        ///// <summary>
        ///// Will raise the OnAgentAdded Event to Notify the caller of the agent that was added to the enviroment.
        ///// </summary>
        //event EventHandler<EnviromentAgentAddedEventArgs<TPrecept, TAction>> AgentAddedEventHandler;
        ///// <summary>
        ///// Will raise the OnAgentRemoved Event to Notify the caller of the agent that was removed to the enviroment.
        ///// </summary>
        //event EventHandler<EnviromentAgentRemovedEventArgs<TPrecept, TAction>> AgentRemovedDelegate;
        ///// <summary>
        ///// Will raise the OnAgentActed Event to Notify the caller of the agent that performed an action within the enviroment.
        ///// </summary>
        //event EventHandler<EnviromentAgentActedEventArgs<TPrecept, TAction>> AgentActedDelegate;


    }
}