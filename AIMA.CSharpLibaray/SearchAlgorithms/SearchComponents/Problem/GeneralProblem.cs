using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem
{
    /// <summary>
    /// Configurable problem which uses objects to explicitly represent the required functions.
    /// <para>Author:Ruediger Lunde
    /// </para>
    /// <para>
    /// Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    /// </para>
    /// <para>Date Created: 17 May 2024 - Date Last Updated: 19 May 2024</para>
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial class GeneralProblem<TState, TAction> : IProblem<TState, TAction>
        where TAction : BaseAgentAction where TState : BaseAgentState
        
    {

        #region Properties
        public TState InitialAgentState { get; private set; }
        private Func<TState, List<TAction>> ApplicableActionsFunc { get; }
        private Func<TState, TAction, TState> TransitionModelResultFunc { get; }
        private Predicate<TState> GoalTestFunc { get; }
        private Func<TState, TAction, TState, double> StepCostFunc { get; }
        #endregion

        #region Cstor

        /// <summary>
        /// Constructs A problem with the specified components, which includes A step cost function.
        /// </summary>
        /// <param name="initialStateOfAgent">The initial state of the agent.</param>
        /// <param name="agentActionsForStateFunc">A description of the possible actions available to the agent.</param>
        /// <param name="modelResultFunc"> A description of what each action does; the formal name for this is the transition model, specified by A function RESULT(s, A) that returns the state that results from doing action A in state s.</param>
        /// <param name="goalTestFunction">test determines whether A given state is A goal state.</param>
        /// <param name="stepCostFunc">A path cost function that assigns A numeric cost to each path. The problem-solving-agent chooses A cost function that reflects its own performance measure.</param>
        public GeneralProblem(
            TState initialStateOfAgent,
            Func<TState, List<TAction>> agentActionsForStateFunc,
            Func<TState, TAction, TState> modelResultFunc,
            Predicate<TState> goalTestFunction,
            Func<TState, TAction, TState, double> stepCostFunc)
        {
            InitialAgentState = initialStateOfAgent;
            ApplicableActionsFunc = agentActionsForStateFunc;
            TransitionModelResultFunc = modelResultFunc;
            GoalTestFunc = goalTestFunction;
            StepCostFunc = stepCostFunc;
        }
        /// <summary>
        /// Constructs A problem with the specified components, and A default step cost function (i.e. 1 per step).
        /// </summary>
        /// <param name="initialStateOfAgent">The initial state of the agent.</param>
        /// <param name="agentActionsForStateFunc">A description of the possible actions available to the agent.</param>
        /// <param name="modelResultFunc"> A description of what each action does; the formal name for this is the transition model, specified by A function RESULT(s, A) that returns the state that results from doing action A in state s.</param>
        /// <param name="goalTestFunction">test determines whether A given state is A goal state.</param>
        public GeneralProblem(
            TState agentIntialState,
            Func<TState, List<TAction>> agentActionsForStateFunc,
            Func<TState, TAction, TState> modelResultFunc,
            Predicate<TState> goalTestFunction
            ) : this(
                agentIntialState,
                agentActionsForStateFunc,
                modelResultFunc,
                goalTestFunction,
                
                (s, a, sDelta) => { return 1.0; })
        { }
        #endregion

        #region Methods
        public List<TAction> GetApplicableActionsForAgentCurrentState(TState agentCurrentState)
        {
            return ApplicableActionsFunc.Invoke(agentCurrentState);
        }
        public TState GetTransitionModelResult(TState agentCurrentState, TAction agentAction)
        {
            return TransitionModelResultFunc.Invoke(agentCurrentState, agentAction);
        }
        public bool TestGoal(TState state)
        {
            return GoalTestFunc.Invoke(state);
        }
        public double GetStepCost(TState state, TAction action, TState stateDelta)
        {
            return StepCostFunc.Invoke(state, action, stateDelta);
        }
        public virtual bool TestSolution(Node<TState, TAction> node)
        {
            return TestGoal(node.NodeState);
        }
        #endregion
    }
}
