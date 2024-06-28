using AIMA.CSharpLibrary.AgentComponents.State.Base;
using AIMA.CSharpLibrary.Common.DataStructure;
using AIMA.Implementations.VacuumCleaner.Infrastructure.Enumerations;

namespace AIMA.Implementations.VacuumCleaner.State
{

    /// <summary>
    /// 21 June
    /// </summary>

    public partial class VacuumCleanerState : BaseState
    {
        #region Enumeration

        #endregion
        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public EnumVacuumCleanerOperationalState VacuumCleanerMode
        {
            get { return (EnumVacuumCleanerOperationalState)GetAttributeValue(nameof(VacuumCleanerMode)); }
            set { SetDynamicAttributeValue(nameof(VacuumCleanerMode), value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public XYLocation AgentCurrentLocation
        {
            get
            {
                return (XYLocation)GetAttributeValue(nameof(AgentCurrentLocation));
            }
            set
            {
                SetDynamicAttributeValue(nameof(AgentCurrentLocation), value);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool CurrentLocationHasDirt
        {
            get
            {
                return (bool)GetAttributeValue(nameof(CurrentLocationHasDirt));

            }
            set
            {

                SetDynamicAttributeValue(nameof(CurrentLocationHasDirt), value);
            }
        }
        #endregion

        #region Cstor
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public VacuumCleanerState() : base()
        {

        }
        #endregion
    }
}
