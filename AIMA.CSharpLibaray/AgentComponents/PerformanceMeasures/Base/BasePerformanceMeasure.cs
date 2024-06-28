using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Common;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Interface;

namespace AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base
{
    /// <summary>
    /// 16 June
    /// </summary>
    public abstract partial class BasePerformanceMeasure : BaseDynamicProperties, IPerformanceMeasure
    {

        #region cstor
        /// <summary>
        /// 
        /// </summary>
        protected BasePerformanceMeasure():base()
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        public virtual void EvaluatePerformanceMeasureByActionTaken(BaseAction action)
        {
           
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
