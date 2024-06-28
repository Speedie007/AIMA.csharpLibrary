using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Interface;

namespace AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Base
{
    /// <summary>
    /// 18 June
    /// </summary>
    public abstract class BasePerformanceMeasureEventArgs : EventArgs
        
    {

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public BasePerformanceMeasureEventArgs(IPerformanceMeasure performanceMeasure)
        {
            PerformanceMeasure = performanceMeasure;
        }

        /// <value>
        /// 
        /// </value>
        public IPerformanceMeasure PerformanceMeasure { get; }


        #endregion
    }
}
