using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.State;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Extensions;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Interface;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public abstract partial class SearchProcessor<TState, TAction> :
        ISearchForStates<TState, TAction>, ISearchForActions<TState, TAction>
         where TAction : BaseAction, new()
        where TState : BaseAgentState, new()
    {

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        protected FrontierProcessor<TState, TAction> SearchImplementation { get; }
        /// <summary>
        /// 
        /// </summary>
        private BaseFrontierQueue<Node<TState, TAction>> Frontier { get; }
        #endregion

        #region cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchImplementation"></param>
        /// <param name="frontierQueue"></param>
        protected SearchProcessor(
           FrontierProcessor<TState, TAction> searchImplementation,
           BaseFrontierQueue<Node<TState, TAction>> frontierQueue)
        {
            SearchImplementation = searchImplementation;
            Frontier = frontierQueue;
        }
        #endregion
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="problem"></param>
        /// <returns></returns>
        public List<TAction> FindActions(IProblem<TState, TAction> problem)
        {
            SearchImplementation.NodeFactory.UseParentLinks = true;
            Frontier.Clear();
            Node<TState, TAction>? node = SearchImplementation.FindNode(problem, Frontier);

            return node.ToActions();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="problem"></param>
        /// <returns></returns>
        public TState? FindState(IProblem<TState, TAction> problem)
        {
            SearchImplementation.NodeFactory.UseParentLinks = false;
            Frontier.Clear();
            Node<TState, TAction>? node = SearchImplementation.FindNode(problem, Frontier);
            return node != null ? node.ToState(): default;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SearchMetrics GetMetrics()
        {
            return SearchImplementation.SearchMetrics;   
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
    }
}
