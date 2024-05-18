using AIMA.csharpLibrary.AgentComponents.Agent.Interface;
using AIMA.csharpLibrary.AgentComponents.Common;

namespace AIMA.csharpLibrary.AgentComponents.Agent
{
    public partial class AgentState : ComponentDynamicAttributes, IAgentState
    {

        #region Cstor
        public AgentState()
        {

        }
        #endregion

        #region Methods
        //Can place custom or override methods here.
        public override string DynamicAtrributeType()
        {
            return GetType().Name;
        }
        #endregion
    }
}
