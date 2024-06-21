using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.PerformaneMeasure
{
    /// <summary>
    /// 18 june
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public class AgentPerformanceMeasureUpdatedEventArgs<TPrecept, TAction> : BasePerformanceMeasureEventArgs
        where TPrecept : BasePrecept, new()
        where TAction : AbstractAction, new()
    {

        #region cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="performaceMeasure"></param>
        public AgentPerformanceMeasureUpdatedEventArgs(
            AbstractAgent<TPrecept, TAction> agent,
            BasePerformaceMeasure performaceMeasure) : base(performaceMeasure)
        {
            Agent = agent;
        }

        /// <value>
        /// <code>Agent</code>
        /// </value>
        public AbstractAgent<TPrecept, TAction> Agent { get; }

        #endregion
    }
}
