using AIMA.CSharpLibrary.AgentComponents.Actions.Base;

namespace AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Interface
{
    /// <summary>
    /// 16 June
    /// </summary>
    public partial interface IPerformanceMeasure
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        void EvaluatePerformanceMeasureByActionTaken(BaseAction action);
    }
}
