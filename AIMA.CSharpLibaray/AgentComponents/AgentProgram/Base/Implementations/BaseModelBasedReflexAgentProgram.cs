using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base.Implementations
{
    /// <summary>
    /// 16 june
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public abstract partial class BaseModelBasedReflexAgentProgram<TPrecept, TAction> : BaseAgentProgram<TPrecept, TAction>
        where TPrecept : BasePrecept, new()
        where TAction : BaseAction, new()
    {

        #region Properties
        /// <summary>
        /// Agent action, the most recent action, initially none
        /// </summary>
        public TAction LastActionExecuted { get; set; }
        #endregion
        /// <summary>
        /// Constructor for the Model Based Reflex Agent Program
        /// </summary>
        public BaseModelBasedReflexAgentProgram()
        {
            LastActionExecuted = new TAction();
        }
        /// <inheritdoc/>
        public override void Initialize()
        {
            throw new NotImplementedException();
        }
        /// <inheritdoc/>
        public override TAction ProcessAgentPecept(TPrecept percept)
        {
            throw new NotImplementedException();
        }


    }
}
