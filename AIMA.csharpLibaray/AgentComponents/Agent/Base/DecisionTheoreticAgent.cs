using AIMA.csharpLibrary.AgentComponents.Agent.Interface;
using AIMA.csharpLibrary.AgentComponents.AgentProgramComponents.Interface;
using AIMA.csharpLibrary.Common.DataStructure;
using AIMA.csharpLibrary.Probability.Interfaces;

namespace AIMA.csharpLibrary.AgentComponents.Agent.Base
{
    /// <summary>
    /// <para>
    /// Artificial Intelligence A Modern Approach (3rd Edition): Figure 13.1, page 484.
    /// </para>
    /// <para>
    /// Figure 13.1  A decision-theoretic agent that selects rational actions.
    /// </para>
    /// <para>
    /// function DT-AGENT(percept) returns an action
    /// persistent: beliefState, probabilistic beliefs about the current state of the world action, the agent's action
    /// </para>
    /// <para>
    /// update beliefState based on action and percept,</para>
    /// <para>calculate outcome probabilities for actions</para>
    /// <para>
    /// given action descriptions and current belief state select action with highest expected utility
    /// </para>
    /// <para>return action</para>
    ///<para>
    ///Author:Ritwik Sharma
    ///</para>
    ///<para>
    ///Author:Samagra
    ///</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 12 May 2024 - Date Last Updated: 11 May 2024</para>
    /// </summary>
    /// <typeparam name="TPrecept">Type which is used to represent percepts</typeparam>
    /// <typeparam name="TAction">Type which is used to represent actions</typeparam>
    public abstract partial class DecisionTheoreticAgent<TPrecept, TAction> : BaseAgent<TPrecept, TAction>
            where TAction : AgentAction, new()
            where TPrecept : AgentPrecept
                
    {
        #region Cstor
        /// <summary>
        /// DecisionTheoreticAgent Constructor
        /// </summary>
        /// <param name="agentProgram">The agent program responsible for processing the agents function.</param>
        /// <param name="isAlive">Is the agent active/alive from instantiation</param>
        protected DecisionTheoreticAgent(IAgentProgram<TPrecept, TAction> agentProgram, bool isAlive= true)
                   : base(agentProgram, isAlive)
        {
            BeliefState = new BeliefState<TPrecept, TAction>();
            Action = new TAction();
            ActionDescriptions = new List<TAction>();
        }
        #endregion

        #region Properties
        public IBeliefState<TPrecept, TAction> BeliefState { get; private set; }
        public TAction Action { get; private set; }
        public List<TAction> ActionDescriptions { get; private set; }
        #endregion

        #region Methods
        /// <summary>
        /// Calculate the possible probalilities for list of possible actions.
        /// </summary>
        /// <param name="actionDescription">permissible action descriptions</param>
        /// <param name="beliefState">current belief state of the agent about the world</param>
        /// <returns>The next action to be taken.</returns>
        public abstract List<Pair<IAgentAction, Double>> CalulateActionProbabilities(
            List<IAgentAction> actionDescription,
            IBeliefState<TPrecept, TAction> beliefState);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="actionProbabilities">Probabilities of various outcomes</param>
        /// <returns>Action with the highest probability.</returns>
        public abstract IAgentAction ActionWithHighestExpectedUtility(List<Pair<IAgentAction, Double>> actionProbabilities);
        #endregion

    }
}
