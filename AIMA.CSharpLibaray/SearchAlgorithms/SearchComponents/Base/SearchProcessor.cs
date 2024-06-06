using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Extensions;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Interface;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Base
{
    public abstract partial class SearchProcessor<TState, TAction> :
        ISearchForStates<TState, TAction>, ISearchForActions<TState, TAction>
         where TAction : BaseAgentAction 
        where TState : DynamicState, new()
    {

        #region Properties
        protected FrontierProcessor<TState, TAction> SearchImplementation { get; }
        private BaseFrontierQueue<Node<TState, TAction>> Frontier { get; }
        #endregion

        #region cstor
        protected SearchProcessor(
           FrontierProcessor<TState, TAction> searchImplementation,
           BaseFrontierQueue<Node<TState, TAction>> frontierQueue)
        {
            SearchImplementation = searchImplementation;
            Frontier = frontierQueue;
        }
        #endregion
       

        public List<TAction> FindActions(IProblem<TState, TAction> problem)
        {
            SearchImplementation.NodeFactory.UseParentLinks = true;
            Frontier.Clear();
            Node<TState, TAction>? node = SearchImplementation.FindNode(problem, Frontier);

            return NodeExtensions<TState, TAction>.ToActions(node);
        }

        public TState? FindState(IProblem<TState, TAction> problem)
        {
            SearchImplementation.NodeFactory.UseParentLinks = false;
            Frontier.Clear();
            Node<TState, TAction>? node = SearchImplementation.FindNode(problem, Frontier);
            return node != null ? NodeExtensions<TState, TAction>.ToState(node): default;
        }

        public SearchMetrics GetMetrics()
        {
            return SearchImplementation.SearchMetrics;   
        }
        public void AddNodeListener(Action<Node<TState, TAction>> listener)
        {
            throw new NotImplementedException();
        }
        public bool removeNodeListener(Action<Node<TState, TAction>> listener)
        {
            throw new NotImplementedException();
        }
    }
}
