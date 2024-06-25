using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules;
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
        #region Properties
        //private Set<Rule<A>> rules;
        #endregion

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public BaseSimpleReflexAgentProgram() : base()
        {
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void InitializeAgentProgramComponents()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="percept"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override TAction ProcessAgentFunctionAsync(TPrecept percept)
        {
            throw new NotImplementedException();
        }
    }
}
