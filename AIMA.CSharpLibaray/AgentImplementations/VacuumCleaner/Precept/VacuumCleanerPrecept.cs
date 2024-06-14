using AIMA.CSharpLibrary.AgentComponents.Precepts;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept
{
    public partial class VacuumCleanerPrecept : BaseAgentPrecept, IEquatable<VacuumCleanerPrecept>
    {
        #region Properties
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

        public bool LocationHasDirt
        {
            get
            {
                return (bool)GetAttributeValue(nameof(LocationHasDirt));

            }
            set
            {

                SetDynamicAttributeValue(nameof(LocationHasDirt), value);
            }
        }

        #endregion
        #region Cstor
        public VacuumCleanerPrecept()
        {
            AgentCurrentLocation = new XYLocation(1, 1);
            LocationHasDirt = false;

        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as VacuumCleanerPrecept);
        }

        public bool Equals(VacuumCleanerPrecept? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   EqualityComparer<XYLocation>.Default.Equals(AgentCurrentLocation, other.AgentCurrentLocation) &&
                   LocationHasDirt == other.LocationHasDirt;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), AgentCurrentLocation, LocationHasDirt);
        }

       

        public static bool operator ==(VacuumCleanerPrecept? left, VacuumCleanerPrecept? right)
        {
            return EqualityComparer<VacuumCleanerPrecept>.Default.Equals(left, right);
        }

        public static bool operator !=(VacuumCleanerPrecept? left, VacuumCleanerPrecept? right)
        {
            return !(left == right);
        }
        #endregion
    }
}
