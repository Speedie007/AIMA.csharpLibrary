using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base.Implementations
{
    /// <summary>
    /// 16 june
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public abstract partial class BaseReflexAgentProgram<TPrecept, TAction> : BaseAgentProgram<TPrecept, TAction>
        where TAction : BaseAction, new()
        where TPrecept : BasePrecept, new()
    {


        #region Cstr
        /// <summary>
        /// 
        /// </summary>
        protected BaseReflexAgentProgram() : base()
        {
        }
        #endregion
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override void Initialize()
        {
            
        }
        
    }
}
