using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.State;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Base;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.SearchImplementation
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial class GraphFrontierProcessor<TState, TAction> : FrontierProcessor<TState, TAction>
        where TAction : AbstractAction, new()
        where TState : BaseState, new()
    {
        /// <summary>
        /// 
        /// </summary>
        protected HashSet<TState> ExploredStates { get; private set; }



        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public GraphFrontierProcessor() : this(new NodeFactory<TState, TAction>())
        { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nodeFactory"></param>
        public GraphFrontierProcessor(NodeFactory<TState, TAction> nodeFactory) : base(nodeFactory)
        {
            ExploredStates = new HashSet<TState>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        public override void AddToFrontier(Node<TState, TAction> node)
        {
            if (!ExploredStates.Contains(node.NodeState))
            {
                Frontier.Enqueue(node);
                UpdateMetrics(Frontier.Size());
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="problem"></param>
        /// <param name="Frontier"></param>
        /// <returns></returns>
        public override Node<TState, TAction>? FindNode(IProblem<TState, TAction> problem, BaseFrontierQueue<Node<TState, TAction>> Frontier)
        {
            // initialize the explored set to be empty
            ExploredStates.Clear();
            return base.FindNode(problem, Frontier);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override bool IsFrontierEmpty()
        {
            CleanUpFrontier();
            UpdateMetrics(Frontier.Size());
            return Frontier.IsEmpty();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Node<TState, TAction> RemoveFromFrontier()
        {
            CleanUpFrontier(); // not really necessary because isFrontierEmpty should be called before...
            Node<TState, TAction> result = Frontier.Dequeue();
            ExploredStates.Add(result.NodeState);
            UpdateMetrics(Frontier.Size());
            return result;
        }


        /// <summary>
        /// Helper method which removes nodes of already explored states from the head of the Frontier.
        /// </summary>
        private void CleanUpFrontier()
        {
            while (!Frontier.IsEmpty() && ExploredStates.Contains(Frontier.Peek().NodeState))
                Frontier.Dequeue();
        }
        #endregion

    }
}
