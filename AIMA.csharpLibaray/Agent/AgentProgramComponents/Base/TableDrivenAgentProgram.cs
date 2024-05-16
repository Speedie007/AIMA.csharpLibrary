using AIMA.csharpLibrary.Agent.AgentComponents;
using AIMA.csharpLibrary.Agent.AgentProgramComponents.Interface;

namespace AIMA.csharpLibrary.Agent.AgentProgramComponents.Base
{
    /// <summary>
    /// <para>Artificial Intelligence A Modern Approach (3rd Edition): Figure 2.7, page 47.</para>
    ///<code>Function TABLE-DRIVEN-AGENT(percept) returns an action</code> 
    ///<code>   Persistent: percepts, a sequence, initially empty</code> 
    ///<code>               table, a table of actions, indexed by percept sequences, initially fully specified</code>
    ///
    /// <code>Append percept to end of percepts</code>
    /// <code>Action = LOOKUP(percepts, table)</code>
    /// <code>Return Action</code>
    /// <para>Figure 2.7 The TABLE-DRIVEN-AGENT program is invoked for each new percept and returns an action each time. It retains the complete percept sequence in memory.</para>
    ///<para>
    ///Author:Ciaran O'Reilly
    ///</para>
    ///<para>
    ///Author:Mike Stampone
    ///</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 13 May 2024 - Date Last Updated: 13 May 2024</para>
    /// </summary>
    /// <typeparam name="TPrecept">Type which is used to represent percepts</typeparam>
    /// <typeparam name="TAction">Type which is used to represent actions </typeparam>
    public abstract partial class TableDrivenAgentProgram<TPrecept, TAction> : IAgentProgram<TPrecept, TAction>
        where TAction : AgentAction
        where TPrecept : AgentPrecept
    {

        public List<TPrecept> Precepts { get; private set; }
        public Dictionary<List<TPrecept>, TAction> Table { get; private set; }

        #region cstor
        /// <summary>
        /// <para>Constructs a TableDrivenAgentProgram with a table of actions, indexed by percept sequences.</para>
        /// </summary>
        protected TableDrivenAgentProgram()
        {
            Precepts = new List<TPrecept>();
            Table = new Dictionary<List<TPrecept>, TAction>();
        }
        /// <summary>
        /// Constructs a TableDrivenAgentProgram with a table of actions, indexed by percept sequences.
        /// </summary>
        /// <param name="perceptsToActionMap">A listing of actions, indexed by percept sequences</param>
        protected TableDrivenAgentProgram(Dictionary<List<TPrecept>, TAction> perceptsToActionMap)
        {
            Table = perceptsToActionMap;
            Precepts = new List<TPrecept>();
        }

        #endregion
        #region Methods
        /// <summary>
        /// <para>Function TABLE-DRIVEN-AGENT(percept) returns an action</para>
        /// </summary>
        /// <param name="percept"></param>
        /// <returns></returns>
        public TAction? ApplyCurrentPrecept(TPrecept percept)
        {
            Precepts.Add(percept);
            return Table.TryGetValue(Precepts, out TAction? a) ? a : default;
        }
        #endregion

    }
}
