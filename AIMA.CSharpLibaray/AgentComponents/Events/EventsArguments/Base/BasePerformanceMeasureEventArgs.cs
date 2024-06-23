using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Base
{
    /// <summary>
    /// 18 june
    /// </summary>
    public abstract class BasePerformanceMeasureEventArgs : EventArgs

    {

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public BasePerformanceMeasureEventArgs(BasePerformanceMeasure performaceMeasure)
        {
            PerformaceMeasure = performaceMeasure;
        }

        /// <value>
        /// 
        /// </value>
        public BasePerformanceMeasure PerformaceMeasure { get; }


        #endregion
    }
}
