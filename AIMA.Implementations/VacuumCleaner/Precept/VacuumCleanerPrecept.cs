using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.Implementations.VacuumCleaner.Precept
{
    /// <summary>
    /// 
    /// </summary>
    public partial class VacuumCleanerPrecept : BasePrecept, IEquatable<VacuumCleanerPrecept>
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
        /// 
        /// </summary>
        public VacuumCleanerPrecept() : this(new XYLocation(-1, -1), false) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="location"></param>
        /// <param name="locationHasDirt"></param>
        public VacuumCleanerPrecept(XYLocation location, bool locationHasDirt) : base()
        {
            AgentCurrentLocation = location;
            CurrentLocationHasDirt = locationHasDirt;

        }

        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return Equals(obj as VacuumCleanerPrecept);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(VacuumCleanerPrecept? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   EqualityComparer<XYLocation>.Default.Equals(AgentCurrentLocation, other.AgentCurrentLocation) &&
                   CurrentLocationHasDirt == other.CurrentLocationHasDirt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), AgentCurrentLocation, CurrentLocationHasDirt);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(VacuumCleanerPrecept? left, VacuumCleanerPrecept? right)
        {
            return EqualityComparer<VacuumCleanerPrecept>.Default.Equals(left, right);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(VacuumCleanerPrecept? left, VacuumCleanerPrecept? right)
        {
            return !(left == right);
        }
    }
}
