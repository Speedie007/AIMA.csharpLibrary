using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures;
using AIMA.Implementations.VacuumCleaner.Actions;
using AIMA.Implementations.VacuumCleaner.PerformanceMeasure.Interface;

namespace AIMA.Implementations.VacuumCleaner.PerformanceMeasure
{
    /// <summary>
    /// 
    /// </summary>
    public partial class VacuumCleanerPerformanceMeasure : DefaultPerformanceMeasure, IVacuumCleanerPerformanceMeasure
    {
        #region Cstor
        
        /// <summary>
        /// 
        /// </summary>
        public VacuumCleanerPerformanceMeasure() : base()
        {
        }
        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        private double GetVacuumCleanerActionPerformanceMeasure(BaseAction action) => action switch
        {
            VacuumCleanerSuckAction => 10,
            VacuumCleanerMoveRightAction => -1,
            VacuumCleanerMoveLeftAction => -1,
            VacuumCleanerMoveUpAction => -1,
            VacuumCleanerMoveDownAction => -1,
            _ => 0
        };
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        public override void EvaluatePerformanceMeasureByActionTaken(BaseAction action)
        {
            Value = GetVacuumCleanerActionPerformanceMeasure(action);
        }

        #endregion
    }
}
