using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base.ProblemSolving;
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
        where TAction : BaseAction, new()
    {

        #region cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="performaceMeasure"></param>
        public AgentPerformanceMeasureUpdatedEventArgs(BaseAgent<TPrecept, TAction> agent, )
        {
            Agent = agent;
            PerformaceMeasure = performaceMeasure;
        }

        /// <value>
        /// <code>Agent</code>
        /// </value>
        public BaseAgent<TPrecept, TAction> Agent { get; }
        
        ///<value>
        ///
        ///</value>
        public BasePerformaceMeasure PerformaceMeasure { get; }
        #endregion
    }
}
