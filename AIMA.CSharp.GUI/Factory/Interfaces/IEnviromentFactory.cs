using AIMA.CSharp.GUI.Forms.VacuumCleaner;
using AIMA.Implementations.VacuumCleaner.Actions;
using AIMA.Implementations.VacuumCleaner.Agents;
using AIMA.Implementations.VacuumCleaner.Environment;
using AIMA.Implementations.VacuumCleaner.PerformanceMeasure;
using AIMA.Implementations.VacuumCleaner.Precept;

namespace AIMA.CSharp.GUI.Factory.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public partial interface IEnvironmentFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="frmSimpleReflexVacuumCleaner"></param>
        /// <returns></returns>
        VacuumCleanerEnvironment<VacuumCleanerPerformanceMeasure, ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> BuildSimpleReflexVacuumCleanerEnvironment(frmSimpleReflexVacuumCleaner  frmSimpleReflexVacuumCleaner);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="frmReflexVacuumCleaner"></param>
        /// <returns></returns>
        VacuumCleanerEnvironment<VacuumCleanerPerformanceMeasure, ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> PrepareReflexVacuumCleanerEnvironment(frmReflexVacuumCleaner frmReflexVacuumCleaner );
    }
}
