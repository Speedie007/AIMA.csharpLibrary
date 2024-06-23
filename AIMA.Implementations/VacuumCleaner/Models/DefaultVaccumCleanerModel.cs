using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Infrastucture.Enumerations;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Models.Base;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Models
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
