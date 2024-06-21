using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure.Interface;
using AIMA.CSharpLibrary.Probability;
using AIMA.CSharpLibrary.Probability.Interfaces;

namespace AIMA.CSharpLibrary.AgentComponents.Agent.Base.DescisionTheory
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
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 12 May 2024 - Date Last Updated: 16 June 2024</para>
    /// </summary>
    /// <typeparam name="TPrecept">Type which is used to represent percepts</typeparam>
    /// <typeparam name="TAction">Type which is used to represent actions</typeparam>
    public abstract partial class AbstractDecisionTheoreticAgent<TPrecept, TAction> : AbstractAgent<TPrecept, TAction>
             where TAction : AbstractAction, new()
         where TPrecept : BasePrecept, new()

    {
       
        #region Cstor
 /// <summary>
        /// AbstractDecisionTheoreticAgent Constructor
        /// </summary>
        protected AbstractDecisionTheoreticAgent() : base()
        {
            BeliefState = new BeliefState<TPrecept, TAction>();
            Action = new TAction();
            ActionDescriptions = new List<TAction>();
        }

        /// <summary>
        /// AbstractDecisionTheoreticAgent Constructor
        /// </summary>
        /// <param name="agentProgram"><inheritdoc/></param>
        /// <param name="performaceMeasure"><inheritdoc/></param>
        /// <param name="isAlive"><inheritdoc/></param>
        protected AbstractDecisionTheoreticAgent(AbstractAgentProgram<TPrecept, TAction> agentProgram, BasePerformaceMeasure performaceMeasure, bool isAlive) : base(agentProgram, performaceMeasure, isAlive)
        {
            BeliefState = new BeliefState<TPrecept, TAction>();
            Action = new TAction();
            ActionDescriptions = new List<TAction>();
        }

        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public IBeliefState<TPrecept, TAction> BeliefState { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public TAction Action { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public List<TAction> ActionDescriptions { get; private set; }
        #endregion

        #region Methods
        /// <summary>
        /// Calculate the possible probalilities for list of possible actions.
        /// </summary>
        /// <param name="actionDescription">permissible action descriptions</param>
        /// <param name="beliefState">current belief state of the agent about the world</param>
        /// <returns>The next action to be taken.</returns>
        public abstract List<Pair<TAction, double>> CalulateActionProbabilities(
            List<TAction> actionDescription,
            IBeliefState<TPrecept, TAction> beliefState);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="actionProbabilities">Probabilities of various outcomes</param>
        /// <returns>ActionExecuted with the highest probability.</returns>
        public abstract TAction ActionWithHighestExpectedUtility(List<Pair<TAction, double>> actionProbabilities);
        #endregion

    }
}
