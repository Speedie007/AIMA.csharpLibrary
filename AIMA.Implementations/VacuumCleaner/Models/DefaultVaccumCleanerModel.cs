using AIMA.Implementations.VacuumCleaner.Infrastructure.Enumerations;
using AIMA.Implementations.VacuumCleaner.Models.Base;
using AIMA.Implementations.VacuumCleaner.Precept;

namespace AIMA.Implementations.VacuumCleaner.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class VacuumCleanerModel : BaseVacuumCleanerModel
    {
        /// <summary>
        /// 
        /// </summary>
        public VacuumCleanerModel()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public EnumVacuumCleanerOperationalState DetermineVacuumCleanerOperationalState(VacuumCleanerPrecept CurrentPrecept)
        {
            if (CurrentPrecept.CurrentLocationHasDirt)
                return EnumVacuumCleanerOperationalState.CleaningMode;
            else
                return EnumVacuumCleanerOperationalState.MovingMode;
        }
    }
}
