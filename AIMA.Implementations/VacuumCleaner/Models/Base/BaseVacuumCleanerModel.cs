using AIMA.CSharpLibrary.AgentComponents.Models.Base;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Models.Interface;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Models.Base
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
        public BaseVacuumCleanerModel():base()
        {
                
        }
        #endregion
    }
}
