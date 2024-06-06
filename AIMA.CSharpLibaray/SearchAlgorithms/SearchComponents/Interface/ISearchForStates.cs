using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Interface
{
    public interface ISearchForStates<TState, TAction>:  ISearchFeedBack<TState, TAction>
        where TAction : BaseAgentAction where TState : DynamicState
    {

        TState? FindState(IProblem<TState, TAction> problem);

      
    }
}
