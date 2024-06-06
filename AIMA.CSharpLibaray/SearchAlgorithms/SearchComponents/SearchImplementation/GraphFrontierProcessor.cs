using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Base;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.SearchImplementation
{
    public partial class GraphFrontierProcessor<TState, TAction> : FrontierProcessor<TState, TAction>
        where TAction : BaseAgentAction
        where TState : DynamicState
    {

        protected HashSet<TState> ExploredStates { get; private set; }



        #region Cstor
        public GraphFrontierProcessor() : this(new NodeFactory<TState, TAction>())
        { }

        public GraphFrontierProcessor(NodeFactory<TState, TAction> nodeFactory) : base(nodeFactory)
        {
            ExploredStates = new HashSet<TState>();
        }
        #endregion

        #region Methods
        public override void AddToFrontier(Node<TState, TAction> node)
        {
            if (!ExploredStates.Contains(node.NodeState))
            {
                Frontier.Enqueue(node);
                UpdateMetrics(Frontier.Size());
            }
        }

        public override Node<TState, TAction>? FindNode(IProblem<TState, TAction> problem, BaseFrontierQueue<Node<TState, TAction>> Frontier)
        {
            // initialize the explored set to be empty
            ExploredStates.Clear();
            return base.FindNode(problem, Frontier);
        }

        public override bool IsFrontierEmpty()
        {
            CleanUpFrontier();
            UpdateMetrics(Frontier.Size());
            return Frontier.IsEmpty();
        }

        public override Node<TState, TAction> RemoveFromFrontier()
        {
            CleanUpFrontier(); // not really necessary because isFrontierEmpty should be called before...
            Node<TState,TAction>? result = Frontier.Dequeue();
            ExploredStates.Add(result.NodeState);
            UpdateMetrics(Frontier.Size());
            return result;
        }

        /**
	 * Helper method which removes nodes of already explored states from the head
	 * of the Frontier.
	 */
        private void CleanUpFrontier()
        {
            while (!Frontier.IsEmpty() && ExploredStates.Contains(Frontier.Peek().NodeState))
                Frontier.Dequeue();
        }
        #endregion

    }
}
