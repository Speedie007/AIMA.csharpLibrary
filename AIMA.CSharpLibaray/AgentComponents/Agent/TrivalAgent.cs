using AIMA.CSharpLibrary.AgentComponents.Actions;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts;

namespace AIMA.CSharpLibrary.AgentComponents.Agent
{
    /// <summary>
    /// 16 June
    /// </summary>
    public partial class TrivalAgent : AbstractAgent<EmptyExamplePrecept, DefaultAction>
    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public TrivalAgent() : base()
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="action"><inheritdoc/></param>
        public override void ExecuteAgentAction(DefaultAction action)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override void ExecuteNoOp()
        {

        }
        #endregion
    }
}
