namespace AIMA.csharpLibrary.AgentProgram.Agent.Interface
{
    /// <summary>
    /// An abstract description of possible discrete Environments in which BaseAgent(s) can perceive and act.
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
    /// <typeparam name="TAction">Type which is used to represent actions</typeparam>
    public partial interface IEnvironment<TPrecept, TAction>
        where TAction : class
        where TPrecept : class
    {

        /// <summary>
        /// <para>There maybe (N)Number of agents operating within the enviroment.</para>
        /// </summary>
        /// <returns>The Agents belonging to this Environment.</returns>
        List<IAgent<TPrecept, TAction>> GetAgents();

        /// <summary>
        /// Add an agent to the Environment.
        /// </summary>
        /// <param name="agent">The agent to be added to the current enviroment.</param>
        void AddAgent(IAgent<TPrecept, TAction> agent);

        /// <summary>
        /// Remove an agent from the environment.
        /// </summary>
        /// <param name="agent">The agent to be removed from the current enviroment.</param>
        void RemoveAgent(IAgent<TPrecept, TAction> agent);

        /// <summary>
        /// Get all EnvironmentObjects that exist in this Environment.
        /// </summary>
       
        /// <returns>Returns a List of EnvironmentObjects that exist in this Environment.</returns>
        List<IEnvironmentObject> GetEnvironmentObjects();

        /// <summary>
        /// Add an EnvironmentObject to the Environment.
        /// </summary>
        /// <param name="environmentObject">The EnvironmentObject to be added.</param>
        void AddEnvironmentObject(IEnvironmentObject environmentObject);

        /// <summary>
        /// Remove an EnvironmentObject from the Environment.
        /// </summary>
        /// <param name="environmentObject">The EnvironmentObject to be removed.</param>
        void RemoveEnvironmentObject(IEnvironmentObject environmentObject);


        /// <summary>
        /// Move the Environment one time step forward.
        /// </summary>
        void Step();

        /// <summary>
        /// Move the Environment n time steps forward.
        /// </summary>
        /// <param name="amountStepsToMoveForward">The number of time steps to move the Environment forward.the number of time steps to move the Environment forward.</param>
        void Step(int amountStepsToMoveForward);

        /// <summary>
        /// Step through time steps until the Environment has no more tasks.
        /// </summary>
        void StepUntilDone();

        /// <summary>
        /// Returns <c>true</c>if the Environment is finished with its current
        /// </summary>
        /// <returns>bool</returns>
        bool IsDone();

        /// <summary>
        /// Retrieve the performance measure(s) associated with an BaseAgent.
        /// </summary>
        /// <param name="agent">The BaseAgent for which a performance measure is to be retrieved.</param>
        /// <returns>The performance measure associated with the BaseAgent.</returns>
        double GetPerformanceMeasure(IAgent<TPrecept, TAction> agent);


    }
}
