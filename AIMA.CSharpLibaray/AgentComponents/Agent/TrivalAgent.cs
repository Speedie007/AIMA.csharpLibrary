using AIMA.CSharpLibrary.AgentComponents.Actions;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts;

namespace AIMA.CSharpLibrary.AgentComponents.Agent
{
    /// <summary>
    /// 16 June
    /// </summary>
    public partial class TrivalAgent : BaseAgent<EmptyPrecept, EmptyAction>
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
        public override void ExecuteAgentAction(EmptyAction action)
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
