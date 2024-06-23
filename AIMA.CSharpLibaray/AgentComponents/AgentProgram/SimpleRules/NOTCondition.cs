using AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules.Base;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules
{
    /// <summary>
    /// 21 June 2024
    /// </summary>
    public partial class NOTCondition : BaseCondition, IEquatable<NOTCondition?>
    {
        #region Properties
        /// <value>
        /// 
        /// </value>
        public BaseCondition NotCondition { get; set; }
        #endregion

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="notCondition"></param>
        public NOTCondition(BaseCondition notCondition)
        {
            NotCondition = notCondition;
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
            return !NotCondition.Validate(state);
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public override string ToString()
        {
            return $"Not[{NotCondition.ToString()}]";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return Equals(obj as NOTCondition);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(NOTCondition? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   EqualityComparer<BaseCondition>.Default.Equals(NotCondition, other.NotCondition);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), NotCondition);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(NOTCondition? left, NOTCondition? right)
        {
            return EqualityComparer<NOTCondition>.Default.Equals(left, right);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(NOTCondition? left, NOTCondition? right)
        {
            return !(left == right);
        }
        #endregion

    }
}
