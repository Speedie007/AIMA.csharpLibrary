using AIMA.CSharpLibrary.AgentComponents.Actions;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Agent;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.PerformanceMeasure;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures;
using AIMA.CSharpLibrary.AgentComponents.Precepts;

namespace AIMA.CSharpLibrary.AgentComponents.Agent
{
    /// <summary>
    /// 16 June
    /// </summary>
    public partial class TrivialAgent : BaseAgent< EmptyExamplePrecept, DefaultAction>
    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public TrivialAgent() : base()
        {
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="agentProgram"><inheritdoc/></param>
        /// <param name="isAlive"><inheritdoc/></param>
        /// <param name="performanceMetricStructure"></param>
        public TrivialAgent(
            BaseAgentProgram< EmptyExamplePrecept, DefaultAction> agentProgram,
            DefaultPerformanceMeasure performanceMetricStructure,
            bool isAlive) : base(agentProgram, performanceMetricStructure, isAlive)
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
        public override void OnAgentMessageNotification(AgentNotificationEventArgs< EmptyExamplePrecept, DefaultAction> agentNotificationEventArgs)
        {
            base.OnAgentMessageNotification(agentNotificationEventArgs);
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="agentPerformanceMeasureUpdatedEventArgs"><inheritdoc/></param>
        public override void OnAgentPerformanceMeasureUpdated(AgentPerformanceMeasureUpdatedEventArgs< EmptyExamplePrecept, DefaultAction> agentPerformanceMeasureUpdatedEventArgs)
        {
            base.OnAgentPerformanceMeasureUpdated(agentPerformanceMeasureUpdatedEventArgs);
        }
        #endregion
    }
}
