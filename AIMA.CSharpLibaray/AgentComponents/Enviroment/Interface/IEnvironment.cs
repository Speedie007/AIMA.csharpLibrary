using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Enviroment.Interface
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
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 10 May 2024 - Date Last Updated: 25 June 2024</para>
    /// <typeparam name="TAgent">Type which is used to represent the agents added to the enviroment.</typeparam>
    /// <typeparam name="TPrecept">Type which is used to represent percepts.</typeparam>
    /// <typeparam name="TAction">Type which is used to represent actions.</typeparam>
    public partial interface IEnvironment<TAgent, TPrecept, TAction>
            where TAction : BaseAction, new()
            where TPrecept : BasePrecept, new()
            where TAgent : BaseAgent<TPrecept, TAction>
    {



        /// <summary>
        /// <para>There maybe (N)Number of agents operating within the enviroment.</para>
        /// </summary>
        /// <returns>The Agents belonging to this Environment.</returns>
        List<TAgent> GetAgents();

        /// <summary>
        /// Add an agent to the Environment.
        /// </summary>
        /// <param name="agent">The agent to be added to the current enviroment.</param>
        void AddAgent(TAgent agent);

        /// <summary>
        /// Remove an agent from the environment.
        /// </summary>
        /// <param name="agent">The agent to be removed from the current enviroment.</param>
        void RemoveAgent(TAgent agent);

        /// <summary>
        /// Get all EnvironmentObjects that exist in this Environment.
        /// <![CDATA[]]>
        /// </summary>
        /// <returns>Returns A List of EnvironmentObjects that exist in this Environment.</returns>
        List<IEnviromentObject> GetEnvironmentObjects();

        /// <summary>
        /// Add an EnvironmentObject to the Environment.
        /// </summary>
        /// <param name="environmentObject">The EnvironmentObject to be added.</param>
        void AddEnvironmentObject(IEnviromentObject environmentObject);

        /// <summary>
        /// Remove an EnvironmentObject from the Environment.
        /// </summary>
        /// <param name="environmentObject">The EnvironmentObject to be removed.</param>
        void RemoveEnvironmentObject(IEnviromentObject environmentObject);


        /// <summary>
        /// Move the Environment one time step forward.
        /// </summary>
        /// <param name="cancellationToken">Task Cancellation Token, Uses to handle the cancellation of stepping through the enviroment.</param>
        /// <returns></returns>
        Task StepAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Move the Environment n time steps forward.
        /// </summary>
        /// <param name="amountStepsToMoveForward">The number of time steps to move the Environment forward.the number of time steps to move the Environment forward.</param>
        /// <param name="cancellationToken">Task Cancellation Token, Uses to handle the cancellation of stepping through the enviroment.</param>
        /// <returns></returns>
        Task StepAsync(int amountStepsToMoveForward, CancellationToken cancellationToken);

        /// <summary>
        /// Step through time steps until the Environment has no more tasks.
        /// </summary>
        /// <param name="cancellationToken">Task Cancellation Token, Uses to handle the cancellation of stepping through the enviroment.</param>
        /// <returns></returns>
        Task StepUntilDoneAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Check to see if there are any agents currently busy completing required tasks.
        /// </summary>
        /// <returns><c>true</c> if there are no agent alive, else False</returns>
        bool IsDone();

        ///// <summary>
        ///// Retrieve the performance measure(s) associated with an BaseAgent.
        ///// </summary>
        ///// <param name="agent">The BaseAgent for which A performance measure is to be retrieved.</param>
        ///// <returns>The performance measure associated with the BaseAgent.</returns>
        //double GetAgentPerformanceMeasure(TAgent agent);

        /// <summary>
        /// Creates random enviromential change with in the enviroment this is to test the rigor of the agent program for example.
        /// <para>
        /// Method for implementing dynamic environments in which not all changes are directly caused by agent action execution.
        /// </para>
        /// <para>
        /// The default implementation does nothing.
        /// </para>
        /// </summary>
        void CreateExogenousChange();

        ///// <summary>
        ///// <para>
        ///// Method is called when an agent doesn't select an action when asked. Default implementation does nothing.
        ///// </para>
        ///// <remarks>
        ///// Sub-classes can for example modify the isDone status.
        ///// </remarks>
        ///// </summary>
        ///// <param name="agent">The Agent that was step forward.</param>
        //void ExecuteNoOp(TAgent agent);

        ///// <summary>
        ///// Primitive operations to be implemented by subclasses:
        ///// </summary>
        ///// <param name="agent">The Current Agent being processed.</param>
        ///// <param name="action">The ActionExecuted to be performed by the Agent.</param>
        //void ProcessAgentAcuators(TAgent agent, TAction action);

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="forAgent"></param>
        ///// <param name="addTo"></param>
        ///// <returns></returns>
        //bool UpdatePerformanceMeasure(TAgent forAgent, double addTo);
    }
}
