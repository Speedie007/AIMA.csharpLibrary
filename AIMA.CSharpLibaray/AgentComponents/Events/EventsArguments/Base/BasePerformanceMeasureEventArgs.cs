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
        public BasePerformanceMeasureEventArgs(BasePerformaceMeasure performaceMeasure)
        {
            PerformaceMeasure = performaceMeasure;
        }

        /// <value>
        /// 
        /// </value>
        public BasePerformaceMeasure PerformaceMeasure { get; }


        #endregion
    }
}
