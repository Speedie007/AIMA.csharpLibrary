namespace AIMA.csharpLibrary.Search.Components.Interface
{
    public partial interface ISearchForActions<TState,TAction>
    {

        List<TAction> findActions(Problem<TState, TAction> problem);

        Metrics GetMetrics();
    }
}
