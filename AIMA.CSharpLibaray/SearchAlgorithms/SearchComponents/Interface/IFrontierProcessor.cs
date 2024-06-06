using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Base;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Interface
{
    public interface IFrontierProcessor<TState, TAction> 
        where TAction : BaseAgentAction
        where TState: DynamicState
    {
        bool EarlyGoalTest { get; }
        void AddToFrontier(Node<TState, TAction> node);
        Node<TState, TAction> RemoveFromFrontier();
        bool IsFrontierEmpty();

        Node<TState, TAction>? FindNode(IProblem<TState, TAction> problem, BaseFrontierQueue<Node<TState, TAction>> frontier);
    }
}