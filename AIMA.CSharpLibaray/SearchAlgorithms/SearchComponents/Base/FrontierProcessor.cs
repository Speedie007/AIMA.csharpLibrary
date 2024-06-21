using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.State;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Interface;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public abstract partial class FrontierProcessor<TState, TAction> : IFrontierProcessor<TState, TAction>
        where TAction : AbstractAction, new()
        where TState : BaseState, new()
    {

        #region Properties
        private const string METRIC_NODES_EXPANDED = "nodesExpanded";
        private const string METRIC_QUEUE_SIZE = "queueSize";
        private const string METRIC_MAX_QUEUE_SIZE = "maxQueueSize";
        private const string METRIC_PATH_COST = "pathCost";
        /// <summary>
        /// 
        /// </summary>
        protected BaseFrontierQueue<Node<TState, TAction>> Frontier { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public NodeFactory<TState, TAction> NodeFactory { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public bool EarlyGoalTest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SearchMetrics SearchMetrics { get; private set; }
        #endregion

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nodeFactory"></param>
        protected FrontierProcessor(NodeFactory<TState, TAction> nodeFactory)
        {
            Frontier = default!;// set to inform the compiler that it is ok for the Frontier to be null at initilization.
            NodeFactory = nodeFactory;
            EarlyGoalTest = false;
            SearchMetrics = new SearchMetrics();
        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="problem"></param>
        /// <param name="frontier"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 
        /// </summary>
        protected virtual void ClearMetrics()
        {
            SearchMetrics.Set(METRIC_NODES_EXPANDED, 0);
            SearchMetrics.Set(METRIC_QUEUE_SIZE, 0);
            SearchMetrics.Set(METRIC_MAX_QUEUE_SIZE, 0);
            SearchMetrics.Set(METRIC_PATH_COST, 0);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="queueSize"></param>
        protected virtual void UpdateMetrics(int queueSize)
        {
            SearchMetrics.Set(METRIC_QUEUE_SIZE, queueSize);
            int maxQSize = SearchMetrics.GetInt(METRIC_MAX_QUEUE_SIZE);
            if (queueSize > maxQSize)
            {
                SearchMetrics.Set(METRIC_MAX_QUEUE_SIZE, queueSize);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        protected virtual Node<TState, TAction>? AsOptionalGoal(Node<TState, TAction> node)
        {
            if (node != null)
                SearchMetrics.Set(METRIC_PATH_COST, node.PathCost);
            return node;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        public abstract void AddToFrontier(Node<TState, TAction> node);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract Node<TState, TAction> RemoveFromFrontier();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract bool IsFrontierEmpty();
        #endregion
    }
}
