namespace AIMA.csharpLibrary.Agent.AgentProgramComponents.Interface
{
    /// <summary>
    /// Artificial Intelligence A Modern Approach (3rd Edition): pg 35.
    /// <para>
    /// An agent's behavior is described by the 'agent function' that maps any given
    /// percept sequence to an action. Internally, the agent function for an 
    /// artificial agent will be implemented by an agent program.
    /// </para>
    ///
    ///<para>
    ///Author:Ravi Mohan
    ///</para>
    ///<para>
    ///Author:Ciaran O'Reilly
    ///</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 10 May 2024 - Date Last Updated: 10 May 2024</para>
    /// </summary>
    /// <typeparam name="TPrecept">Type which is used to represent percepts</typeparam>
    /// <typeparam name="TAction">Type which is used to represent actions</typeparam>
    public partial interface IAgentProgram<TPrecept, TAction>
    {

        /// <summary>
        /// The Agent's program, which maps any given percept sequences to an action.
        /// </summary>
        /// <param name="percept">The current percept of a sequence perceived by the Agent.</param>
        /// <returns>The Action to be taken in response to the currently perceived percept. Empty replaces NoOp in earlier implementations.</returns>
        delegate TAction Apply(TPrecept percept);
    }
}
