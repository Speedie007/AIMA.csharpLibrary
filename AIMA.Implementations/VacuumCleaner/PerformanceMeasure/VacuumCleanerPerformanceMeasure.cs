using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.Implementations.VacuumCleaner.Actions;
using AIMA.Implementations.VacuumCleaner.PerformanceMeasure.Interface;

namespace AIMA.Implementations.VacuumCleaner.PerformanceMeasure
{
    /// <summary>
    /// 
    /// </summary>
    public partial class VacuumCleanerPerformanceMeasure : BasePerformanceMeasure, IVacuumCleanerPerformanceMeasure
    {
        #region Properties
        /// <summary>
        /// 
        /// </summary>
        private int TotalActionsCompleted
        {
            get { return (int)GetAttributeValue(nameof(TotalActionsCompleted)); }
            set { SetDynamicAttributeValue(nameof(TotalActionsCompleted), value); }
        }

        private int TotalMoveLeftActionsCompleted
        {
            get { return (int)GetAttributeValue(nameof(TotalMoveLeftActionsCompleted)); }
            set { SetDynamicAttributeValue(nameof(TotalMoveLeftActionsCompleted), value); }
        }
        private int TotalMoveRightActionsCompleted
        {
            get { return (int)GetAttributeValue(nameof(TotalMoveRightActionsCompleted)); }
            set { SetDynamicAttributeValue(nameof(TotalMoveRightActionsCompleted), value); }
        }
        private int TotalMoveUpActionsCompleted
        {
            get { return (int)GetAttributeValue(nameof(TotalMoveUpActionsCompleted)); }
            set { SetDynamicAttributeValue(nameof(TotalMoveUpActionsCompleted), value); }
        }
        private int TotalMoveDownActionsCompleted
        {
            get { return (int)GetAttributeValue(nameof(TotalMoveDownActionsCompleted)); }
            set { SetDynamicAttributeValue(nameof(TotalMoveDownActionsCompleted), value); }
        }
        private int TotalSuckDownActionsCompleted
        {
            get { return (int)GetAttributeValue(nameof(TotalSuckDownActionsCompleted)); }
            set { SetDynamicAttributeValue(nameof(TotalSuckDownActionsCompleted), value); }
        }

        private int TotalActionsFailed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        protected double VacuumCleanerPerformanceValue
        {
            //get;set;
            //get { return (double)GetAttributeValue(AgentComponentDefaults.PERFORMANCE_MEASURE); }
            //set { SetDynamicAttributeValue(AgentComponentDefaults.PERFORMANCE_MEASURE, value); }
            get { return (double)GetAttributeValue(nameof(VacuumCleanerPerformanceValue)); }
            set { SetDynamicAttributeValue(nameof(VacuumCleanerPerformanceValue), value); }
        }
        #endregion
        #region Cstor

        /// <summary>
        /// 
        /// </summary>
        public VacuumCleanerPerformanceMeasure() : base()
        {
            VacuumCleanerPerformanceValue = 0;
            TotalActionsCompleted = 0;
            TotalMoveDownActionsCompleted = 0;
            TotalMoveLeftActionsCompleted = 0;
            TotalMoveRightActionsCompleted = 0;
            TotalMoveUpActionsCompleted = 0;
            TotalSuckDownActionsCompleted = 0;
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
            VacuumCleanerSuckAction => -5,
            VacuumCleanerMoveRightAction => 2.5,
            VacuumCleanerMoveLeftAction => 2.5,
            VacuumCleanerMoveUpAction => 2.5,
            VacuumCleanerMoveDownAction => 2.5,
            _ => 0.0
        };
        private void UpdateVacuumCleanerActionPerformanceMeasure(BaseAction action)
        {
            switch (action)
            {
                case VacuumCleanerMoveRightAction:
                    {
                        TotalMoveRightActionsCompleted += 1;
                    }
                    break;
                case VacuumCleanerMoveLeftAction:
                    {
                        TotalMoveLeftActionsCompleted += 1;
                    }
                    break;
                case VacuumCleanerMoveUpAction:
                    {
                        TotalMoveUpActionsCompleted += 1;
                    }
                    break;
                case VacuumCleanerMoveDownAction:
                    {
                        TotalMoveDownActionsCompleted += 1;
                    }
                    break;
                default:
                    {
                        TotalSuckDownActionsCompleted += 1;
                    }
                    break;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        public override void EvaluatePerformanceMeasureByActionTaken(BaseAction action)
        {
            VacuumCleanerPerformanceValue += GetVacuumCleanerActionPerformanceMeasure(action);
            UpdateVacuumCleanerActionPerformanceMeasure(action);
        }

        #endregion
    }
}
