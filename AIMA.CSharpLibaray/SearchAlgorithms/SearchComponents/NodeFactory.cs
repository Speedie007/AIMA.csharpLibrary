using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents
{
    public partial class NodeFactory<TState, TAction>
        where TAction : BaseAgentAction where TState : BaseAgentState
    {

        #region Properties
        public bool UseParentLinks { get; set; }
        #endregion

        #region cstor
        public NodeFactory():this(true){}
        public NodeFactory(bool useParentLinks)
        {
            UseParentLinks = useParentLinks;
        }
        #endregion

        #region Methods
        public Node<TState, TAction> CreateNode(TState state)
        {
            return new Node<TState, TAction>(state);
        }

        public Node<TState, TAction> CreateNode(TState state, Node<TState, TAction> parent, TAction action, double stepCost)
        {
            return new Node<TState, TAction>(state, UseParentLinks ? parent : null, action, parent.PathCost + stepCost);
        }

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
