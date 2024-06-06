namespace AIMA.csharpLibrary.Search.Problem
{
    /// <summary>
    /// 19 may 2024
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public static class ProblemDelegates<TState,TAction> 
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="a"></param>
        /// <param name="sDelta"></param>
        /// <returns></returns>
        public delegate double StepCostFunction(TState s, TAction a, TState sDelta);
        /// <summary>
        /// <para>A description of the possible actions available to the agent.</para>
        /// <remarks>We say that  each of these actions is applicable in s.</remarks>
        /// </summary>
        /// <param name="agentCurrentState"></param>
        /// <returns>Given a particular state s, returns the set of actions the can be executed in s.</returns>
        public delegate List<TAction> GetApplicableActionsForAgentCurrentStateFunction(TState agentCurrentState);
        /// <summary>
        /// A description of what each action does.
        /// <para>
        /// The formal name for this is the transition model, specified by a function RESULT(s,a) that returns the state that results from doing action a in state s.
        /// </para>
        /// </summary>
        /// <param name="agentCurrentState"></param>
        /// <param name="agentAction"></param>
        /// <returns>Successor State, which refers to any state reachable from a given state by a single action. </returns>
        public delegate TState GetTransitionModelResultFunction(TState agentCurrentState,TAction agentAction);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentCurrentState"></param>
        /// <returns></returns>
        public delegate bool GoalTestFunction(TState agentCurrentState);

        
    }
}
