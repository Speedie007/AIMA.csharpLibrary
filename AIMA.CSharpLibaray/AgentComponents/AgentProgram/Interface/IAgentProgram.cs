using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.AgentComponents.Sensor.Interface;
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
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 10 May 2024 - Date Last Updated: 10 May 2024</para>
    /// </summary>
    /// <typeparam name="TPrecept">Type which is used to represent percepts</typeparam>
    /// <typeparam name="TAction">Type which is used to represent actions</typeparam>
    
    public partial interface IAgentProgram<TPrecept, TAction>
        where TPrecept : BasePrecept, new()
        where TAction : BaseAction, new()
             
    {
        /// <summary>
        /// 
        /// </summary>
        Dictionary<Type, ISensor< TPrecept, TAction>> Sensors { get; }
        /// <summary>
        /// Concrete implementations of the AgentProgram should implement the Init() method so that it can initialize the relevant calls as/if required, such as  the setState(), setModel(), and setRules() method.
        /// <para>Called when the program is loaded.</para>
        /// </summary>
        void InitializeAgentProgramComponents();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="environmentObjects"></param>
        /// <param name="action"></param>
        /// <param name="agent"></param>
        void ProcessAgentAction(LinkedDictionarySet<IEnvironmentObject> environmentObjects, TAction action, BaseAgent< TPrecept, TAction> agent);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="percept"></param>
        /// <returns></returns>
        TAction ProcessAgentFunctionAsync(TPrecept percept);

        /// <summary>
        /// The BaseAgent's program Precept To ActionExecuted Function, which maps any given percept sequences to an action.
        /// <para>The current percept of A sequence perceived by the BaseAgent.</para>
        /// </summary>
        /// <returns>The ActionExecuted to be taken in response to the currently perceived percept. Empty replaces NoOp in earlier implementations.</returns>
        Func<TPrecept, BaseAction> AgentPreceptToActionFunction { get; }

        /// <summary>
        /// 
        /// </summary>
        Func<LinkedDictionarySet<IEnvironmentObject>, IAgent< TPrecept, TAction>, TPrecept> SensorPollingFunction { get; }
    };
}


