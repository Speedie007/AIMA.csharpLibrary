using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.State.Base;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Extensions;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Interface;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces;

namespace AIMA.CSharpLibrary.SearchAlgorithms.Uniformed
{
    /// <summary>
    /// 21 May
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial class DepthLimitedSearch<TState, TAction> : ISearchForActions<TState, TAction>, ISearchForStates<TState, TAction>
        where TAction : BaseAction, new()
        where TState : BaseState, new()
    {

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public const string METRIC_NODES_EXPANDED = "nodesExpanded";
        /// <summary>
        /// 
        /// </summary>
        public const string METRIC_PATH_COST = "pathCost";

        private int Limit { get; set; }
        private HashSet<TState>? ExploredStates;
        /// <summary>
        /// 
        /// </summary>
        public Node<TState, TAction> cutoffNode = new(new TState());
        /// <summary>
        /// 
        /// </summary>
        protected NodeFactory<TState, TAction> NodeFactory { get; private set; }
        private readonly SearchMetrics SearchMetrics;
        #endregion

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="limit"></param>
        public DepthLimitedSearch(int limit) : this(limit, new NodeFactory<TState, TAction>())
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="nodeFactory"></param>
        public DepthLimitedSearch(int limit, NodeFactory<TState, TAction> nodeFactory)
        {
            Limit = limit;
            NodeFactory = nodeFactory;
            SearchMetrics = new();
        }


        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="useCycleDetection"></param>
        /// <returns></returns>
        public DepthLimitedSearch<TState, TAction> SetCycleDetection(bool useCycleDetection)
        {
            ExploredStates = useCycleDetection ? new HashSet<TState>() : null;
            return this;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="problem"></param>
        /// <returns></returns>
        public virtual List<TAction> FindActions(IProblem<TState, TAction> problem)
        {
            NodeFactory.UseParentLinks = true;
            Node<TState, TAction> node = FindNode(problem);
            return !IsCutoffResult(node) ? node.ToActions() : new List<TAction>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="problem"></param>
        /// <returns></returns>
        public TState FindState(IProblem<TState, TAction> problem)
        {
            NodeFactory.UseParentLinks = false;
            Node<TState, TAction> node = FindNode(problem);
            return !IsCutoffResult(node) ? node.ToState() : new TState();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="problem"></param>
        /// <returns></returns>
        public Node<TState, TAction> FindNode(IProblem<TState, TAction> problem)
        {
            ClearMetrics();
            // return RECURSIVE-DLS(MAKE-NODE(INITIAL-STATE[problem]), problem, limit)
            Node<TState, TAction> node = RecursiveDLS(NodeFactory.CreateNode(problem.InitialAgentState), problem, Limit);
            return node;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="problem"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        private Node<TState, TAction> RecursiveDLS(Node<TState, TAction> node, IProblem<TState, TAction> problem, int limit)
        {
            // if problem.GOAL-TEST(node.STATE) then return SOLUTION(node)
            if (problem.TestSolution(node))
            {
                SearchMetrics.Set(METRIC_PATH_COST, node.PathCost);
                return node;
            }
            else if (0 == limit)// || Tasks.currIsCancelled())
            {
                // else if limit = 0 then return cutoff
                return cutoffNode;
            }
            else
            {
                // else
                // cutoff_occurred? <- false
                bool cutoffOccurred = false;
                Node<TState, TAction> result = new();// = null;
                // for each action in problem.ACTIONS(node.STATE) do
                SearchMetrics.IncrementInt(METRIC_NODES_EXPANDED);
                foreach (Node<TState, TAction> child in GetSuccessors(node, problem))
                {
                    // child <- CHILD-NODE(problem, node, action)
                    // result <- RECURSIVE-DLS(child, problem, limit - 1)
                    result = RecursiveDLS(child, problem, limit - 1);
                    // if result = cutoff then cutoff_occurred? <- true
                    if (result == cutoffNode)
                        cutoffOccurred = true;
                    else if (result != null)
                    {
                        // else if result != failure then return result
                        cutoffOccurred = false;
                        break;
                    }
                }
                if (ExploredStates != null)
                    ExploredStates.Remove(node.NodeState);
                // if cutoff_occurred? then return cutoff else return failure
                return cutoffOccurred ? cutoffNode : result;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="problem"></param>
        /// <returns></returns>
        private List<Node<TState, TAction>> GetSuccessors(Node<TState, TAction> node, IProblem<TState, TAction> problem)
        {
            List<Node<TState, TAction>> result = NodeFactory.GetSuccessors(node, problem);
            if (ExploredStates != null)
            {
                ExploredStates.Add(node.NodeState);
                result = result.Where(n => !ExploredStates.Contains(n.NodeState)).ToList();
            }
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool IsCutoffResult(Node<TState, TAction> node)
        {
            return node != null && node == cutoffNode;
        }


        private void ClearMetrics()
        {
            SearchMetrics.Set(METRIC_NODES_EXPANDED, 0);
            SearchMetrics.Set(METRIC_PATH_COST, 0);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SearchMetrics GetMetrics()
        {
            return SearchMetrics;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listener"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool removeNodeListener(Action<Node<TState, TAction>> listener)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listener"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void AddNodeListener(Action<Node<TState, TAction>> listener)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
