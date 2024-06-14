using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts;
using AIMA.CSharpLibrary.AgentComponents.Sensors.Interface;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.Interface
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
    public partial interface IAgentProgram<TAgent,TPrecept, TAction>
        where TPrecept : BaseAgentPrecept,new()
        where TAction : BaseAgentAction,new()
        where TAgent : IAgent<TPrecept, TAction>
    {
        Dictionary<Type, IAgentSensor<TPrecept, TAction>> Sensors { get; }
        /// <summary>
        /// Concrete implemeations of the AgentPrgrom should implement the Init() method so that it can initialize the relevant calls as/if required, such as  the setState(), setModel(), and setRules() method.
        /// <para>Called when the program is loaded.</para>
        /// </summary>
        void Initialize();
        void InitializeSensors();
        TPrecept ProcessSensors(LinkedHashSet<IEnvironmentObject> EnvironmentObjects, TAgent agent);

        /// <summary>
        /// The BaseAgent's program, which maps any given percept sequences to an action.
        /// </summary>
        /// <param name="percept">The current percept of A sequence perceived by the BaseAgent.</param>
        /// <returns>The Action to be taken in response to the currently perceived percept. Empty replaces NoOp in earlier implementations.</returns>
        Func<TPrecept, TAction> PreceptToActionFunc { get; }
    };
}


