using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Base
{
    /// <summary>
    /// 18 June
    /// </summary>
    public abstract class BasePerformanceMeasureEventArgs<TPerformanceMeasure> : EventArgs
        where TPerformanceMeasure: BasePerformanceMeasure, new()
    {

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public BasePerformanceMeasureEventArgs(TPerformanceMeasure performanceMeasure)
        {
            PerformanceMeasure = performanceMeasure;
        }

        /// <value>
        /// 
        /// </value>
        public TPerformanceMeasure PerformanceMeasure { get; }


        #endregion
    }
}
