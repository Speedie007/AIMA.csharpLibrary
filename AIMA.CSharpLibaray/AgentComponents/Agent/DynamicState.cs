using AIMA.CSharpLibrary.AgentComponents.Common;

namespace AIMA.CSharpLibrary.AgentComponents.Agent
{
    public partial class DynamicState : ComponentDynamicAttributes, IState
    {

        #region Cstor
        public DynamicState()
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
