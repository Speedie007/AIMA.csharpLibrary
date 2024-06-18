using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.State;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Base;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces;
using System.Threading.Tasks;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.SearchImplementation
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial class TreeFrontierProcessor<TState, TAction> : FrontierProcessor<TState, TAction>
        where TAction : BaseAction
        where TState : BaseAgentState

    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public TreeFrontierProcessor() : this(new NodeFactory<TState, TAction>())
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nodeFactory"></param>
        public TreeFrontierProcessor(NodeFactory<TState, TAction> nodeFactory) : base(nodeFactory)
        {

        }
        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        public override void AddToFrontier(Node<TState, TAction> node)
        {
            Frontier.Enqueue(node);
            UpdateMetrics(Frontier.Size());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public  override Node<TState, TAction> RemoveFromFrontier()
        {
            Node<TState, TAction> result = Frontier.Dequeue()!;
            UpdateMetrics(Frontier.Size());
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public  override bool IsFrontierEmpty()
        {
            return Frontier.Size() == 0;
        }
    }
}
