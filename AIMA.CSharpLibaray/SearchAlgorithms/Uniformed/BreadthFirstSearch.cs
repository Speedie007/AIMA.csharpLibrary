﻿using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.State.Base;
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
    public partial class BreadthFirstSearch<TState, TAction> : SearchProcessor<TState, TAction>
        where TAction : BaseAction, new()
        where TState : BaseState, new()
    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public BreadthFirstSearch() : this(new GraphFrontierProcessor<TState, TAction>()) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchImplementation"></param>
        //public BreadthFirstSearch(FrontierProcessor<TState, TAction> searchImplementation)
        //    : base(searchImplementation, FrontierExtensions<Node<TState, TAction>, TState, TAction>.CreateFIFOFrontier()) { }

        public BreadthFirstSearch(FrontierProcessor<TState, TAction> searchImplementation)
            : base(searchImplementation, FrontierExtensionsV1.CreateFIFOFrontier<TState, TAction>()) { }

        #endregion

    }
}
