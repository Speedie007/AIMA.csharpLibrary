using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.PerformanceMeasure
{
    /// <summary>
    /// 18 June
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>

    public class AgentPerformanceMeasureUpdatedEventArgs<TPrecept, TAction> : BasePerformanceMeasureEventArgs
        where TPrecept : BasePrecept, new()
        where TAction : BaseAction, new()
          
    {

        #region cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="performanceMeasure"></param>
        public AgentPerformanceMeasureUpdatedEventArgs(
            BaseAgent<TPrecept, TAction> agent,
            IPerformanceMeasure performanceMeasure) : base(performanceMeasure)
        {
            Agent = agent;
        }

        /// <value>
        /// <code>Agent</code>
        /// </value>
        public BaseAgent<TPrecept, TAction> Agent { get; }

        #endregion
    }
}
