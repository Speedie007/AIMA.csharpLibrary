using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.State;
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
        where TAction : AbstractAction, new()
        where TState : BaseState, new()
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
            : base(searchImplementation, FrontierExtensionsV1.CreateLIFOQueue<TState, TAction>()) { }
        #endregion

    }
}
