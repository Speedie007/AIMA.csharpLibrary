using AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules.Base;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules
{
    /// <summary>
    /// 21 June
    /// </summary>
    public partial class ANDCondition : AbstractCondition, IEquatable<ANDCondition?>
    {
        #region Properties
        /// <value> LeftCondition </value>
        protected AbstractCondition LeftCondition { get; private set; }
        /// <value>Condition</value>
        protected AbstractCondition RightCondition { get; private set; }
        #endregion

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="leftCondition"></param>
        /// <param name="rightCondition"></param>
        public ANDCondition(AbstractCondition leftCondition, AbstractCondition rightCondition)
        {
            LeftCondition = leftCondition;
            RightCondition = rightCondition;
        }



        #endregion

        #region Methods
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="TState"><inheritdoc/></typeparam>
        /// <param name="dynamicProperties"><inheritdoc/></param>
        /// <returns></returns>
        public override bool Validate<TState>(TState dynamicProperties)
        {
            return LeftCondition.Validate(dynamicProperties) && RightCondition.Validate(dynamicProperties);
        }
        /// <summary>
        /// Lists the Left and right condition being eveuated.
        /// </summary>
        /// <returns>String, Left AND Right</returns>
        public override string? ToString()
        {
            return $"[{LeftCondition.ToString} && {RightCondition.ToString}]";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return Equals(obj as ANDCondition);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(ANDCondition? other)
        {
            return other is not null &&
                   EqualityComparer<AbstractCondition>.Default.Equals(LeftCondition, other.LeftCondition) &&
                   EqualityComparer<AbstractCondition>.Default.Equals(RightCondition, other.RightCondition);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(LeftCondition, RightCondition);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(ANDCondition? left, ANDCondition? right)
        {
            return EqualityComparer<ANDCondition>.Default.Equals(left, right);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(ANDCondition? left, ANDCondition? right)
        {
            return !(left == right);
        }
        #endregion
    }
}
