using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.State.Base;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Base;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Extensions;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.SearchImplementation;

namespace AIMA.CSharpLibrary.SearchAlgorithms.Uniformed
{
    /// <summary>
    /// 21 May
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial class UniformCostSearch<TState, TAction> : SearchProcessor<TState, TAction>
        where TAction : BaseAction, new()
        where TState : BaseState, new()
    {

        /// <summary>
        /// Creates A UniformCostSearch instance using GraphSearch
        /// </summary>
        public UniformCostSearch() : this(new GraphFrontierProcessor<TState, TAction>()) { }
        /// <summary>
        ///  Combines UniformCostSearch queue definition with the specified search execution strategy.
        /// </summary>
        /// <param name="searchImplementation"></param>
        //public UniformCostSearch(FrontierProcessor<TState, TAction> searchImplementation)
        //    : base(searchImplementation, FrontierExtensions<Node<TState, TAction>, TState, TAction>.CreatePriorityQueueFrontier())
        //{
        //}

        public UniformCostSearch(FrontierProcessor<TState, TAction> searchImplementation)
            : base(searchImplementation, FrontierExtensionsV1.CreatePriorityQueueFrontier<TState, TAction>())
        {
        }
    }
}
