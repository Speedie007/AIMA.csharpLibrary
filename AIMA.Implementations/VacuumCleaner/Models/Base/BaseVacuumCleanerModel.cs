using AIMA.CSharpLibrary.AgentComponents.Models.Base;
using AIMA.Implementations.VacuumCleaner.Models.Interface;

namespace AIMA.Implementations.VacuumCleaner.Models.Base
{
    /// <summary>
    /// 22 June
    /// </summary>
    public abstract partial class BaseVacuumCleanerModel : BaseModel, IVacuumCleanerModel
    {

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public BaseVacuumCleanerModel() : base()
        {

        }
        #endregion
    }
}
