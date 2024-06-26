﻿using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.State.Base;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Interface
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial interface ISearchFeedBack<TState, TAction>
        where TAction : BaseAction, new()
        where TState : BaseState, new()
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Returns all the SearchMetrics of the search.</returns>
        SearchMetrics GetMetrics();

        /// <summary>
        /// Adds A listener to the list of node listeners. It is informed whenever A node is expanded during search.
        /// </summary>
        /// <param name="listener"></param>
        void AddNodeListener(Action<Node<TState, TAction>> listener);

        /// <summary>
        ///  Removes A listener from the list of node listeners.
        /// </summary>
        /// <param name="listener"></param>
        /// <returns></returns>
        bool removeNodeListener(Action<Node<TState, TAction>> listener);
    }
}
