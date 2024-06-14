using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Base;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces;
using System.Threading.Tasks;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.SearchImplementation
{
    public partial class TreeFrontierProcessor<TState, TAction> : FrontierProcessor<TState, TAction>
        where TAction : BaseAgentAction
        where TState : BaseAgentState

    {
        #region Cstor
        public TreeFrontierProcessor() : this(new NodeFactory<TState, TAction>())
        {

        }
        public TreeFrontierProcessor(NodeFactory<TState, TAction> nodeFactory) : base(nodeFactory)
        {

        }
        #endregion


        
        public override void AddToFrontier(Node<TState, TAction> node)
        {
            Frontier.Enqueue(node);
            UpdateMetrics(Frontier.Size());
        }

        public  override Node<TState, TAction> RemoveFromFrontier()
        {
            Node<TState, TAction> result = Frontier.Dequeue()!;
            UpdateMetrics(Frontier.Size());
            return result;
        }

        public  override bool IsFrontierEmpty()
        {
            return Frontier.Size() == 0;
        }
    }
}
