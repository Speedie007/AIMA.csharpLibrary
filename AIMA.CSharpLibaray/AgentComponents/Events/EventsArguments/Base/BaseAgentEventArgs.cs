using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Base
{
    /// <summary>
    /// 16 June
    /// </summary>
    public abstract partial class BaseAgentEventArgs<TPrecept, TAction> : EventArgs
        where TPrecept : BasePrecept, new()
        where TAction : BaseAction, new()
    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        protected BaseAgentEventArgs(BaseAgent<TPrecept, TAction> agent)
        {
            Agent = agent;
        }

        /// <value>
        /// 
        /// </value>
        public BaseAgent<TPrecept, TAction> Agent { get; }
        #endregion
    }
}
