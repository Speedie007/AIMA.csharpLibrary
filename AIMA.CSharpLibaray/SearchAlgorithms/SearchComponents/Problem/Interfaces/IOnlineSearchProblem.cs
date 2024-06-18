namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces
{

    /// <summary>
    /// Artificial Intelligence A Modern Approach(3rd Edition): page 147.
    /// <para>
    /// An online search problem must be solved by an agent executing actions, rather than by pure computation.
    /// </para>
    /// <para>We assume A deterministic and fully observable environment(Chapter 17 relaxes these assumptions), but we stipulate that the agent knows only the following:</para>
    /// <para>ACTIONS(s), which returns A list of actions allowed in state s;
    /// </para>
    /// <para>The step-cost function c(s, A, s') - note that this cannot be used until the agent knows that s' is the outcome; and</para>
    /// <para>GOAL-TEST(s).</para>
    ///<para>
    ///Author:Ruediger Lunde
    ///</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 19 May 2024 - Date Last Updated: 19 May 2024</para>
    /// </summary>
    /// <typeparam name="TState">The type used to represent states</typeparam>
    /// <typeparam name="TAction">The type of the actions to be used to navigate through the state space.</typeparam>
    public partial interface IOnlineSearchProblem<TState, TAction>
    {
        /// <summary>
        /// Returns the initial state of the agent.
        /// </summary>
        /// <returns>Returns the initial state of the agent.</returns>
        TState InitialAgentState { get; }

        /// <summary>
        /// <para>A description of the possible actions available to the agent.</para>
        /// <remarks>We say that  each of these actions is applicable in s.</remarks>
        /// </summary>
        /// <param name="agentCurrentState"></param>
        /// <returns>Given A particular state s, returns the Set of actions the can be executed in s.</returns>
        List<TAction> GetApplicableActionsForAgentCurrentState(TState agentCurrentState);

        /// <summary>
        /// <para>
        /// Determines whether A given state is A goal state.
        /// </para>
        /// <para>
        /// Sometimes there  ia an explicit Set of possible goal states, an the test simply checks wheahter the given state is one of them.
        /// </para>
        /// </summary>
        /// <param name="state"></param>
        /// <returns>true if is the required goal state, else false.</returns>
        bool TestGoal(TState state);

        /// <summary>
        /// Returns the step cost of taking action action in state state to reach state.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="action">The type of the actions to be used to navigate through the state space</param>
        /// <param name="stateDelta">stateDelta  denoted by c(s, A, s').</param>
        /// <returns>The step cost of taking action action in state state to reach state</returns>
        double GetStepCost(TState state, TAction action, TState stateDelta);

    }
}
