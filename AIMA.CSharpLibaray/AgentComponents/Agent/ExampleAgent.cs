using AIMA.CSharpLibrary.AgentComponents.Actions;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Agent;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.PerformanceMeasure;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures;
using AIMA.CSharpLibrary.AgentComponents.Precepts;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Agent
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public partial class ExampleAgent : BaseAgent< EmptyExamplePrecept, DefaultAction>
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ExampleAgent() : base()
        {
        }
        /// <inheritdoc/>
        public ExampleAgent(
            BaseAgentProgram< EmptyExamplePrecept, DefaultAction> agentProgram,
            DefaultPerformanceMeasure performanceMetricStructure,
            bool isAlive) : base(agentProgram, performanceMetricStructure, isAlive)
        {
        }






        /// <inheritdoc/>
        public override void ExecuteNoOp()
        {
            //Does Nothing by default.
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        /// <param name="environmentObjects"></param>
        public override void ProcessAgentActuators(DefaultAction action, LinkedDictonarySet<IEnvironmentObject> environmentObjects)
        {
            base.ProcessAgentActuators(action, environmentObjects);
        }

    }
}
