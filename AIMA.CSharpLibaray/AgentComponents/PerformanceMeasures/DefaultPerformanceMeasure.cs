using AIMA.CSharpLibrary.AgentComponents.Common;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;

namespace AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DefaultPerformanceMeasure : BasePerformaceMeasure
    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public DefaultPerformanceMeasure() : base()
        {
        }
        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public double PreformanceMeasureValue
        { 
            get { return (double)GetAttributeValue(AgentComponentDefaults.PERFORMANCE_MEASURE); }
            set { SetDynamicAttributeValue(AgentComponentDefaults.PERFORMANCE_MEASURE, value); }
        }
        #endregion
       
    }
}
