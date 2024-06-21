using AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules.Base;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules
{
    /// <summary>
    /// 21 June
    /// </summary>
    public partial class EQUALCondition : AbstractCondition, IEquatable<EQUALCondition?>
    {
        #region Properties
        /// <value>
        /// 
        /// </value>
        protected object PropertyKey { get; private set; }
        /// <value>
        /// 
        /// </value>
        protected object PropertyValue { get; private set; }
        #endregion

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyKey"></param>
        /// <param name="propertyValue"></param>
        public EQUALCondition(object propertyKey, object propertyValue)
        {
            PropertyKey = propertyKey;
            PropertyValue = propertyValue;
        }
        #endregion

        #region Methods
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="TState"><inheritdoc/></typeparam>
        /// <param name="state"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public override bool Validate<TState>(TState state)
        {
            return PropertyValue.Equals(state.GetAttributeValue(PropertyKey));
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public override string ToString()
        {
            return $"{PropertyKey.GetType().ToString()}=={PropertyValue.ToString()}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return Equals(obj as EQUALCondition);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(EQUALCondition? other)
        {
            return other is not null &&
                   EqualityComparer<object>.Default.Equals(PropertyKey, other.PropertyKey) &&
                   EqualityComparer<object>.Default.Equals(PropertyValue, other.PropertyValue);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(PropertyKey, PropertyValue);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(EQUALCondition? left, EQUALCondition? right)
        {
            return EqualityComparer<EQUALCondition>.Default.Equals(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(EQUALCondition? left, EQUALCondition? right)
        {
            return !(left == right);
        }
        #endregion

    }
}
