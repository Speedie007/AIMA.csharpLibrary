using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using System.Collections.Generic;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base.Implementations
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public abstract partial class AbstractSimpleReflexAgentProgram<TPrecept, TAction> : AbstractAgentProgram<TPrecept, TAction>
        where TAction : AbstractAction, new()
        where TPrecept : BasePrecept, new()
    {
        #region Properties
        private Set<Rule<A>> rules;
        #endregion

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public AbstractSimpleReflexAgentProgram():base()
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
        public override TAction ProcessAgentFunction(TPrecept percept)
        {
            throw new NotImplementedException();
        }
    }
}
