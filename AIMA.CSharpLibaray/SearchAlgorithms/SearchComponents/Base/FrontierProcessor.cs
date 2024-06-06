using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Interface;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces;
using System.Threading.Tasks;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Base
{
    public abstract partial class FrontierProcessor<TState, TAction> : IFrontierProcessor<TState, TAction> 
        where TAction : BaseAgentAction
        where TState: DynamicState
    {

        #region Properties
        private const string METRIC_NODES_EXPANDED = "nodesExpanded";
        private const string METRIC_QUEUE_SIZE = "queueSize";
        private const string METRIC_MAX_QUEUE_SIZE = "maxQueueSize";
        private const string METRIC_PATH_COST = "pathCost";

        protected BaseFrontierQueue<Node<TState, TAction>> Frontier { get; private set; }
        public NodeFactory<TState, TAction> NodeFactory { get; private set; }
        public bool EarlyGoalTest { get; set; }
        public SearchMetrics SearchMetrics { get; private set; }
        #endregion

        #region Cstor
        protected FrontierProcessor(NodeFactory<TState, TAction> nodeFactory)
        {
            Frontier = default!;// set to inform the compiler that it is ok for the Frontier to be null at initilization.
            NodeFactory = nodeFactory;
            EarlyGoalTest = false;
            SearchMetrics = new SearchMetrics();
        }
        #endregion

        #region Methods
        public virtual Node<TState, TAction>? FindNode(IProblem<TState, TAction> problem, BaseFrontierQueue<Node<TState, TAction>> frontier)
        {
            Frontier = frontier;
            ClearMetrics();

            Node<TState, TAction> root = NodeFactory.CreateNode(problem.InitialAgentState);

            AddToFrontier(root);
            if (EarlyGoalTest && problem.TestSolution(root))
                return root;

            while (!IsFrontierEmpty())//&& !Tasks.currIsCancelled())
            {
                // choose A leaf node and remove it from the frontier
                Node<TState, TAction> node = RemoveFromFrontier();
                // if the node contains A goal state then return the corresponding solution
                if (!EarlyGoalTest && problem.TestSolution(node))
                    return (node);

                // expand the chosen node and add the successor nodes to the frontier
                foreach (Node<TState, TAction> successor in NodeFactory.GetSuccessors(node, problem))
                {
                    AddToFrontier(successor);
                    if (EarlyGoalTest && problem.TestSolution(successor))
                        return successor;
                }
            }
            // if the frontier is empty then return failure
            return null;
        }

        protected virtual void ClearMetrics()
        {
            SearchMetrics.Set(METRIC_NODES_EXPANDED, 0);
            SearchMetrics.Set(METRIC_QUEUE_SIZE, 0);
            SearchMetrics.Set(METRIC_MAX_QUEUE_SIZE, 0);
            SearchMetrics.Set(METRIC_PATH_COST, 0);
        }

        protected virtual void UpdateMetrics(int queueSize)
        {
            SearchMetrics.Set(METRIC_QUEUE_SIZE, queueSize);
            int maxQSize = SearchMetrics.GetInt(METRIC_MAX_QUEUE_SIZE);
            if (queueSize > maxQSize)
            {
                SearchMetrics.Set(METRIC_MAX_QUEUE_SIZE, queueSize);
            }
        }

        protected virtual Node<TState, TAction>? AsOptionalGoal(Node<TState, TAction> node)
        {
            if (node != null)
                SearchMetrics.Set(METRIC_PATH_COST, node.PathCost);
            return node;
        }

        public abstract void AddToFrontier(Node<TState, TAction> node);
        public abstract Node<TState, TAction> RemoveFromFrontier();
        public abstract bool IsFrontierEmpty();

        
        #endregion
    }
}
