using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base.Implementations
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public abstract partial class BaseSimpleReflexAgentProgram<TPrecept, TAction> : BaseAgentProgram<TPrecept, TAction>
        where TAction : BaseAction, new()
        where TPrecept : BasePrecept, new()
    {

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public BaseSimpleReflexAgentProgram():base()
        {
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void Initialize()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="percept"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override TAction ProcessAgentPecept(TPrecept percept)
        {
            throw new NotImplementedException();
        }
    }
}
