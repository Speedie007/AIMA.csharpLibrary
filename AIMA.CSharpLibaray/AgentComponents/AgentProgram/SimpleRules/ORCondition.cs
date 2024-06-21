using AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules.Base;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules
{
    /// <summary>
    /// 21 June 2024
    /// </summary>
    public partial class ORCondition : AbstractCondition, IEquatable<ORCondition>
    {
        #region Properties
        /// <value> LeftCondition </value>
        protected AbstractCondition LeftCondition { get; private set; }
        /// <value>Right Condition</value>
        protected AbstractCondition RightCondition { get; private set; }
        #endregion

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="leftCondition"></param>
        /// <param name="rightCondition"></param>
        public ORCondition(AbstractCondition leftCondition, AbstractCondition rightCondition)
        {
            LeftCondition = leftCondition;
            RightCondition = rightCondition;
        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="state"></param>
        /// <returns></returns>
        public override bool Validate<TState>(TState state)
        {
            return LeftCondition.Validate(state) || RightCondition.Validate(state);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return Equals(obj as ORCondition);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(ORCondition? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   EqualityComparer<AbstractCondition>.Default.Equals(LeftCondition, other.LeftCondition) &&
                   EqualityComparer<AbstractCondition>.Default.Equals(RightCondition, other.RightCondition);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), LeftCondition, RightCondition);
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public override string? ToString()
        {
            return $"{LeftCondition.ToString()} Or {RightCondition.ToString()}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(ORCondition? left, ORCondition? right)
        {
            return EqualityComparer<ORCondition>.Default.Equals(left, right);
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="left"><inheritdoc/></param>
        /// <param name="right"><inheritdoc/></param>
        /// <returns></returns>
        public static bool operator !=(ORCondition? left, ORCondition? right)
        {
            return !(left == right);
        }
        #endregion
    }
}
