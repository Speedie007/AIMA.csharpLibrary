using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Base;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Extensions;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.SearchImplementation;

namespace AIMA.CSharpLibrary.SearchAlgorithms.Uniformed
{
    public partial class UniformCostSearch<TState, TAction> : SearchProcessor<TState, TAction>
        where TAction : BaseAgentAction
        where TState : BaseAgentState, new()
    {

        /// <summary>
        /// Creates A UniformCostSearch instance using GraphSearch
        /// </summary>
        public UniformCostSearch() : this(new GraphFrontierProcessor<TState, TAction>()){}
        /// <summary>
        ///  Combines UniformCostSearch queue definition with the specified search execution strategy.
        /// </summary>
        /// <param name="searchImplementation"></param>
        public UniformCostSearch(FrontierProcessor<TState, TAction> searchImplementation)
            : base(searchImplementation, FrontierExtensions<Node<TState, TAction>, TState, TAction>.CreatePriorityQueueFrontier())
        {
        }
    }
}
