using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.PerformanceMeasure
{
    /// <summary>
    /// 18 June
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    /// <typeparam name="TPerformanceMeasure"></typeparam>
    public class AgentPerformanceMeasureUpdatedEventArgs<TPerformanceMeasure,TPrecept, TAction> : BasePerformanceMeasureEventArgs<TPerformanceMeasure>
        where TPrecept : BasePrecept, new()
        where TAction : BaseAction, new()
         where TPerformanceMeasure : BasePerformanceMeasure, new() 
    {

        #region cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="performanceMeasure"></param>
        public AgentPerformanceMeasureUpdatedEventArgs(
            BaseAgent<TPerformanceMeasure,TPrecept, TAction> agent,
            TPerformanceMeasure performanceMeasure) : base(performanceMeasure)
        {
            Agent = agent;
        }

        /// <value>
        /// <code>Agent</code>
        /// </value>
        public BaseAgent<TPerformanceMeasure,TPrecept, TAction> Agent { get; }

        #endregion
    }
}
