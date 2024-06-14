using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.Common;

namespace AIMA.CSharpLibrary.AgentComponents.Agent
{
    public abstract partial class BaseAgentState : ComponentDynamicAttributes, IAgentState
    {

        #region Cstor
        public BaseAgentState()
        {

        }
        #endregion

        #region Methods
        //Can place custom or override methods here.
        public override Type DynamicAtrributeType()
        {
            return GetType();
        }
        #endregion
    }
}
