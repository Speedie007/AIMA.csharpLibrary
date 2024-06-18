using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base.Implementations
{
    /// <summary>
    /// 16 june
    /// </summary>
    /// <typeparam name="TPrecept"><inheritdoc/></typeparam>
    /// <typeparam name="TAction"><inheritdoc/></typeparam>
    public abstract partial class BaseReflexAgentProgram<TPrecept, TAction> : BaseAgentProgram<TPrecept, TAction>
        where TAction : BaseAction, new()
        where TPrecept : BasePrecept, new()
    {


        #region Cstr
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        protected BaseReflexAgentProgram() : base()
        {
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override void Initialize()
        {
            
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="percept"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public override TAction ProcessAgentPecept(TPrecept percept)
        {
           return new();
        }
        #endregion



    }
}
