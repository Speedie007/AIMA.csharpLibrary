using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.State;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial interface IProblem<TState, TAction> : IOnlineSearchProblem<TState, TAction>
        where TAction : AbstractAction, new()
        where TState : BaseState, new()
    {
        /// <summary>
        /// A description of what each action does.
        /// <para>
        /// The formal name for this is the transition AgentModel, specified by A function RESULT(s,A) that returns the state that results from doing action A in state s.
        /// </para>
        /// </summary>
        /// <param name="agentCurrentState"></param>
        /// <param name="agentAction"></param>
        /// <returns>Successor CurrentState, which refers to any state reachable from A given state by A single action. </returns>
        TState GetTransitionModelResult(TState agentCurrentState, TAction agentAction);
        /// <summary>
        /// Tests whether A node represents an acceptable solution. 
        /// <para>The default implementation delegates the check to the goal test.</para>
        /// <para>Other implementations could make use of the additional information given by the node (e.g. the sequence of actions leading to the node).</para>
        /// <para>To compute all or the five best solutions (not just the best), tester implementations could return false and internally collect the paths of all nodes whose state passes the goal test until enough solutions have been collected.</para>
        /// <para>Search implementations should always access the goal test via this method to support solution acceptance testing.</para>
        /// </summary>
        /// <param name="node"></param>
        /// <returns>true if goals are obtained, else false</returns>
        bool TestSolution(Node<TState, TAction> node);
    }
}
