using AIMA.CSharpLibrary.AgentComponents.State;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.State
{
    /// <summary>
    /// 21 June
    /// </summary>
    public partial class VacuumCleanerState : BaseState
    {

        #region Properties
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
