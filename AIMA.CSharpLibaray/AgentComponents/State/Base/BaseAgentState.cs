using AIMA.CSharpLibrary.AgentComponents.Common;
using AIMA.CSharpLibrary.AgentComponents.State.Interface;

namespace AIMA.CSharpLibrary.AgentComponents.State
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class BaseAgentState : ComponentDynamicAttributes, IAgentState
    {

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public BaseAgentState()
        {

        }
        #endregion

        #region Methods
        //Can place custom or override methods here.
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Type DynamicAtrributeType()
        {
            return GetType();
        }
        #endregion
    }
}
