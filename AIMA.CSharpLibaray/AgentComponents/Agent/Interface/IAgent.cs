using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Agent.Interface
{
    /// <summary>
    /// <para>
    /// Artificial Intelligence A Modern Approach (3rd Edition): Figure 2.1, page 35.
    /// </para>
    /// <para>Figure 2.1 Agents interact with environments through sensors and actuators.</para>
    ///<para>
    ///Author:Ravi Mohan
    ///</para>
    ///<para>
    ///Author:Ciaran O'Reilly
    ///</para>
    ///<para>
    ///Author:Ruediger Lunde
    ///</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 10 May 2024 - Date Last Updated: 11 May 2024</para>
    /// </summary>
    /// <typeparam name="TPrecept">Type which is used to represent percepts</typeparam>
    /// <typeparam name="TAction">Type which is used to represent actions</typeparam>
    public partial interface IAgent<TPrecept, TAction> : IEnvironmentObject
        where TPrecept : BasePrecept, new()
        where TAction : BaseAction, new()
    {

        /// <summary>
        /// Call the BaseAgent's program, which maps any given percept sequences to an action.
        /// </summary>
        /// <param name="percept">The current percept of the current enviroment perceived by the BaseAgent.</param>
        /// <returns>
        /// <para>The ActionExecuted to be taken in response to the currently perceived percept.</para>
        /// <para>An ActionExecuted of type NoOperation replaces NoOp in earlier implementations.</para></returns>
        TAction ProcessAgentFunction(TPrecept percept);

        /// <summary>
        /// Will initiate polling the enviromental sensors that the agent has avaialble to it.
        /// </summary>
        /// <param name="EnvironmentObjects">Current Objects within in the agents enviroment</param>
        /// <returns>Agent Precept, based on the current state of the enviroment it is operating in.</returns>
        TPrecept PollAgentSensors(LinkedDictonarySet<IEnvironmentObject> EnvironmentObjects);

        /// <summary>
        /// <para>Life-cycle indicator as to the liveness of an BaseAgent.</para>
        /// Perperty: Value true if the BaseAgent is to be considered alive, false otherwise.
        /// </summary>
        public bool IsAlive { get; set; }

        /// <summary>
        /// <para>
        /// Method is called when an agent doesn't select an action when asked. Default implementation does nothing.
        /// </para>
        /// <remarks>
        /// Sub-classes can for example modify the isDone status.
        /// </remarks>
        /// </summary>
        void ExecuteNoOp();

        /// <summary>
        /// Operations to be implemented by Agent:
        /// </summary>
        /// <param name="action">The ActionExecuted to be performed by the Agent.</param>
        void ExecuteAgentAction(TAction action);
        void InitialiseAgentProgram();
    }
}
