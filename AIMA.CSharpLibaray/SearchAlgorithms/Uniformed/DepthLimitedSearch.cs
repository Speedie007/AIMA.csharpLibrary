using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Extensions;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Interface;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces;

namespace AIMA.CSharpLibrary.SearchAlgorithms.Uniformed
{
    public partial class DepthLimitedSearch<TState, TAction> : ISearchForActions<TState, TAction>, ISearchForStates<TState, TAction>
        where TAction : BaseAgentAction
        where TState : DynamicState, new()
    {

        #region Properties
        public const string METRIC_NODES_EXPANDED = "nodesExpanded";
        public const string METRIC_PATH_COST = "pathCost";

        private int Limit { get; set; }
        private HashSet<TState>? ExploredStates;
        public Node<TState, TAction> cutoffNode = new(new TState());
        protected NodeFactory<TState, TAction> NodeFactory { get; private set; }
        private readonly SearchMetrics SearchMetrics;
        #endregion

        #region Cstor
        public DepthLimitedSearch(int limit) : this(limit, new NodeFactory<TState, TAction>())
        {

        }

        public DepthLimitedSearch(int limit, NodeFactory<TState, TAction> nodeFactory)
        {
            Limit = limit;
            NodeFactory = nodeFactory;
            SearchMetrics = new();
        }


        #endregion

        #region Methods

        public DepthLimitedSearch<TState, TAction> SetCycleDetection(bool useCycleDetection)
        {
            ExploredStates = useCycleDetection ? new HashSet<TState>() : null;
            return this;
        }
        public virtual List<TAction> FindActions(IProblem<TState, TAction> problem)
        {
            NodeFactory.UseParentLinks = true;
            Node<TState, TAction> node = FindNode(problem);
            return !IsCutoffResult(node) ? NodeExtensions<TState, TAction>.ToActions(node) : new List<TAction>();
        }

        public TState FindState(IProblem<TState, TAction> problem)
        {
            NodeFactory.UseParentLinks = false;
            Node<TState, TAction> node = FindNode(problem);
            return !IsCutoffResult(node) ? NodeExtensions<TState, TAction>.ToState(node) : new TState();
        }

        public Node<TState, TAction> FindNode(IProblem<TState, TAction> problem)
        {
            ClearMetrics();
            // return RECURSIVE-DLS(MAKE-NODE(INITIAL-STATE[problem]), problem, limit)
            Node<TState, TAction> node = RecursiveDLS(NodeFactory.CreateNode(problem.InitialAgentState), problem, Limit);
            return node;
        }

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
                Node<TState, TAction> result = new(new TState());// = null;
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

        public bool IsCutoffResult(Node<TState, TAction> node)
        {
            return node != null && node == cutoffNode;
        }


        private void ClearMetrics()
        {
            SearchMetrics.Set(METRIC_NODES_EXPANDED, 0);
            SearchMetrics.Set(METRIC_PATH_COST, 0);
        }

        public SearchMetrics GetMetrics()
        {
            return SearchMetrics;
        }

        public bool removeNodeListener(Action<Node<TState, TAction>> listener)
        {
            throw new NotImplementedException();
        }
        public void AddNodeListener(Action<Node<TState, TAction>> listener)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
