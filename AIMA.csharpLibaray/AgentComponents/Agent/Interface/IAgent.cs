﻿using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.EventsArguments.Base;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts;
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
    ///Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 10 May 2024 - Date Last Updated: 11 May 2024</para>
    /// </summary>
    /// <typeparam name="TPrecept">Type which is used to represent percepts</typeparam>
    /// <typeparam name="TAction">Type which is used to represent actions</typeparam>
    public partial interface IAgent<TPrecept, TAction> : IEnvironmentObject
        where TPrecept : BaseAgentPrecept, new()
        where TAction : BaseAgentAction, new()  
    {

        /// <summary>
        /// Call the BaseAgent's program, which maps any given percept sequences to an action.
        /// </summary>
        /// <param name="percept">The current percept of A sequence perceived by the BaseAgent.</param>
        /// <returns>
        /// <para>The Action to be taken in response to the currently perceived percept.</para>
        /// <para>Empty replaces NoOp in earlier implementations.</para></returns>
        TAction ActOnPrecept(TPrecept percept);
        /// <summary>
        /// Will initiavte polling the enviromental sensors that the agent has avaialble to it.
        /// <para>in real worl eveniroiment this would be implemented internal in the agents program.</para>
        /// </summary>
        /// <returns>the agents precept based on the current state of the enviroment it is operating in.</returns>
        TPrecept PollAgentSensors(LinkedHashSet<IEnvironmentObject> EnvironmentObjects);

        /// <summary>
        /// <para>Life-cycle indicator as to the liveness of an BaseAgent.</para>
        /// Perperty: Value true if the BaseAgent is to be considered alive, false otherwise.
        /// </summary>
        public bool IsAlive { get; set; }

    }
}
