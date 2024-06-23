using AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules.Interfaces;
using AIMA.CSharpLibrary.AgentComponents.State.Base;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules.Base
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class BaseCondition : ICondition, IEquatable<BaseCondition>
    {

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        protected BaseCondition()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public abstract bool Validate<TState>(TState state) where TState : BaseState;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(BaseCondition? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (ReferenceEquals(other, null)) return false;
            if (other == null) return false;

            return true;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            if (!base.Equals(obj)) return false;

            return GetType() == obj.GetType() && ToString().Equals(obj.ToString());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return base.ToString();
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public override int GetHashCode()
        {
            return ToString().GetHashCode() is int hash ? hash : 0;
        }
        #endregion

    }
}
