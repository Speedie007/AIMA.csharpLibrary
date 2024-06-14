using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Base;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Extensions;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.SearchImplementation;

namespace AIMA.CSharpLibrary.SearchAlgorithms.Uniformed
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial class DepthFirstSearch<TState, TAction> : SearchProcessor<TState, TAction>
        where TAction : BaseAgentAction
        where TState : BaseAgentState, new()
    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public DepthFirstSearch() : this(new GraphFrontierProcessor<TState, TAction>()) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchImplementation"></param>
        public DepthFirstSearch(FrontierProcessor<TState, TAction> searchImplementation)
            : base(searchImplementation, FrontierExtensions<Node<TState, TAction>, TState, TAction>.CreateLIFOQueue()) { }
        #endregion

    }
}
