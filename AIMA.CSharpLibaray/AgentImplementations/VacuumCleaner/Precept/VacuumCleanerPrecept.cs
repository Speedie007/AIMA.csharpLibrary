using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept
{
    public partial class VacuumCleanerPrecept : AgentPrecept
    {
        #region Properties
        public XYLocation AgentCurrentLocation { get; set; }

        #endregion
        #region Cstor
        public VacuumCleanerPrecept()
        {

        }
        #endregion
    }
}
