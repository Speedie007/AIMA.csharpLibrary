using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Environment;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events
{
    /// <summary>
    ///<para>Defines the required event Handlers for the Agent Environment</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 9 June 2024 - Date Last Updated: 16 June 2024</para>
    /// </summary>
    public static class EnvironmentEventHandlers
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TPerformanceMeasure"></typeparam>
        /// <typeparam name="TAgent"></typeparam>
        /// <typeparam name="TPrecept"></typeparam>
        /// <typeparam name="TAction"></typeparam>
        /// <param name="AgentAddedEventArgs"></param>
        public delegate void AgentAddedEventHandler<TPerformanceMeasure, TAgent, TPrecept, TAction>(EnvironmentAgentAddedEventArgs<TPerformanceMeasure, TAgent, TPrecept, TAction> AgentAddedEventArgs)
             where TAction : BaseAction, new()
            where TPrecept : BasePrecept, new()
             where TPerformanceMeasure: BasePerformanceMeasure, new() 
            where TAgent : BaseAgent<TPerformanceMeasure, TPrecept, TAction>, new();
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TAgent"></typeparam>
        /// <typeparam name="TPrecept"></typeparam>
        /// <typeparam name="TAction"></typeparam>
        /// <param name="AgentRemovedArgs"></param>
        /// <typeparam name="TPerformanceMeasure"></typeparam>
        public delegate void AgentRemovedEventHandler<TPerformanceMeasure, TAgent, TPrecept, TAction>(EnvironmentAgentRemovedEventArgs<TPerformanceMeasure, TAgent, TPrecept, TAction> AgentRemovedArgs)
             where TAction : BaseAction, new()
            where TPrecept : BasePrecept, new()
             where TPerformanceMeasure: BasePerformanceMeasure, new() 
            where TAgent : BaseAgent<TPerformanceMeasure, TPrecept, TAction>, new();
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TAgent"></typeparam>
        /// <typeparam name="TPrecept"></typeparam>
        /// <typeparam name="TAction"></typeparam>
        /// <param name="AgentActedEventArgs"></param>
        /// <typeparam name="TPerformanceMeasure"></typeparam>
        public delegate void AgentActedEventHandler<TPerformanceMeasure, TAgent, TPrecept, TAction>(EnvironmentAgentActedEventArgs<TPerformanceMeasure, TAgent, TPrecept, TAction> AgentActedEventArgs)
                where TAction : BaseAction, new()
                where TPrecept : BasePrecept, new()
                 where TPerformanceMeasure: BasePerformanceMeasure, new() 
                where TAgent : BaseAgent<TPerformanceMeasure, TPrecept, TAction>, new();
    }
}
