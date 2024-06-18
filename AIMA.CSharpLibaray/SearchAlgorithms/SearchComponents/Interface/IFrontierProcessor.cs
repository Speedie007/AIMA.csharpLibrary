using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.State;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Base;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Interface
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public interface IFrontierProcessor<TState, TAction> 
        where TAction : BaseAction
        where TState: BaseAgentState
    {
        /// <summary>
        /// 
        /// </summary>
        bool EarlyGoalTest { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        void AddToFrontier(Node<TState, TAction> node);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Node<TState, TAction> RemoveFromFrontier();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool IsFrontierEmpty();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="problem"></param>
        /// <param name="frontier"></param>
        /// <returns></returns>
        Node<TState, TAction>? FindNode(IProblem<TState, TAction> problem, BaseFrontierQueue<Node<TState, TAction>> frontier);
    }
}