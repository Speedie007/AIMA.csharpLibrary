using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Interface
{
    public partial interface ISearchForActions<TState, TAction>: ISearchFeedBack<TState,TAction>
        where TAction : BaseAgentAction
        where TState : BaseAgentState
    {
        List<TAction>? FindActions(IProblem<TState, TAction> problem);

        
    }
}
