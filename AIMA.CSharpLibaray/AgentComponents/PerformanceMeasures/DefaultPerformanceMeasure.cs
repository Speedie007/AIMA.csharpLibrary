using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Common;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;

namespace AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures
{
    /// <summary>
    /// For Default implementations, defaults to using a simple double value as the Performance Measure.
    /// </summary>
    public partial class DefaultPerformanceMeasure : BasePerformanceMeasure
    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public DefaultPerformanceMeasure()
        {

        }


        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        protected double Value { 
            get { return (double)GetAttributeValue(AgentComponentDefaults.PERFORMANCE_MEASURE); } 
            set{ SetDynamicAttributeValue(AgentComponentDefaults.PERFORMANCE_MEASURE, value); } }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void EvaluatePerformanceMeasureByActionTaken(BaseAction action)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
