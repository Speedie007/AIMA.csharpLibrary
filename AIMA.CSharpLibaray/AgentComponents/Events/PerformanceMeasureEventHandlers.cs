using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Enviroment;
namespace AIMA.CSharpLibrary.AgentComponents.Events
{
    /// <summary>
    /// 
    /// </summary>
    public static class PerformanceMeasureEventHandlers
    {

        public delegate void UpdatePerformanceMeasureEventHandler(EnviromentAgentAddedEventArgs<TAgent, TPrecept, TAction> AgentAddedEventArgs);
    }
}
