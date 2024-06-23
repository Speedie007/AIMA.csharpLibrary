using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.State.Base;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial class NodeFactory<TState, TAction>
        where TAction : BaseAction, new()
        where TState : BaseState, new()
    {

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public bool UseParentLinks { get; set; }
        #endregion

        #region cstor
        /// <summary>
        /// 
        /// </summary>
        public NodeFactory() : this(true) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="useParentLinks"></param>
        public NodeFactory(bool useParentLinks)
        {
            UseParentLinks = useParentLinks;
        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public Node<TState, TAction> CreateNode(TState state)
        {
            return new Node<TState, TAction>(state);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        /// <param name="parent"></param>
        /// <param name="action"></param>
        /// <param name="stepCost"></param>
        /// <returns></returns>
        public Node<TState, TAction> CreateNode(TState state, Node<TState, TAction> parent, TAction action, double stepCost)
        {
            return new Node<TState, TAction>(state, UseParentLinks ? parent : null, action, parent.PathCost + stepCost);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="problem"></param>
        /// <returns></returns>
        public List<Node<TState, TAction>> GetSuccessors(Node<TState, TAction> node, IProblem<TState, TAction> problem)
        {
            List<Node<TState, TAction>> successors = new();

            foreach (TAction action in problem.GetApplicableActionsForAgentCurrentState(node.NodeState))
            {
                TState successorState = problem.GetTransitionModelResult(node.NodeState, action);

                double stepCost = problem.GetStepCost(node.NodeState, action, successorState);
                successors.Add(CreateNode(successorState, node, action, stepCost));
            }
            //notifyListeners(node);
            return successors;
        }
        #endregion
    }
}
