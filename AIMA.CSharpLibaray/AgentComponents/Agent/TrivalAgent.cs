using AIMA.CSharpLibrary.AgentComponents.Actions;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Agent;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.PerformaneMeasure;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts;

namespace AIMA.CSharpLibrary.AgentComponents.Agent
{
    /// <summary>
    /// 16 June
    /// </summary>
    public partial class TrivalAgent : BaseAgent<EmptyExamplePrecept, DefaultAction>
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
        /// <param name="agentProgram"><inheritdoc/></param>
        /// <param name="performanceMeasure"><inheritdoc/></param>
        /// <param name="isAlive"><inheritdoc/></param>
        public TrivalAgent(BaseAgentProgram<EmptyExamplePrecept, DefaultAction> agentProgram, BasePerformanceMeasure performanceMeasure, bool isAlive) : base(agentProgram, performanceMeasure, isAlive)
        {
        }

        /// <summary>
        ///<inheritdoc/> 
        /// </summary>
        public override void ExecuteNoOp()
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override void InitialiseAgentProgram()
        {
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="agentNotificationEventArgs"><inheritdoc/></param>
        public override void OnAgentMessageNotification(AgentNotificationEventArgs<EmptyExamplePrecept, DefaultAction> agentNotificationEventArgs)
        {
            base.OnAgentMessageNotification(agentNotificationEventArgs);
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="agentPerformanceMeasureUpdatedEventArgs"><inheritdoc/></param>
        public override void OnAgentPerformanceMeasureUpdated(AgentPerformanceMeasureUpdatedEventArgs<EmptyExamplePrecept, DefaultAction> agentPerformanceMeasureUpdatedEventArgs)
        {
            base.OnAgentPerformanceMeasureUpdated(agentPerformanceMeasureUpdatedEventArgs);
        }
        #endregion
    }
}
