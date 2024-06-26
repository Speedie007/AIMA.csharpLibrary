﻿using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.State.Base;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Interface
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public interface ISearchForStates<TState, TAction> : ISearchFeedBack<TState, TAction>
        where TAction : BaseAction, new()
        where TState : BaseState, new()
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="problem"></param>
        /// <returns></returns>
        TState? FindState(IProblem<TState, TAction> problem);


    }
}
