using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Agent;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.PerformaneMeasure;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Agents
{
    /// <summary>
    /// 16 jume
    /// <inheritdoc/>
    /// </summary>
    public partial class TableDrivenVacuumCleanerAgent : BaseAgent<VacuumCleanerPrecept, VacuumCleanerAction>
    {
        #region Cstor
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public TableDrivenVacuumCleanerAgent() : base() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentProgram"><inheritdoc/></param>
        /// <param name="performaceMeasure"><inheritdoc/></param>
        /// <param name="isAlive"><inheritdoc/></param>
        public TableDrivenVacuumCleanerAgent(BaseAgentProgram<VacuumCleanerPrecept, VacuumCleanerAction> agentProgram, BasePerformanceMeasure performaceMeasure, bool isAlive) : base(agentProgram, performaceMeasure, isAlive)
        {
        }


        #endregion

        #region Methods
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override void ExecuteNoOp()
        {
        }

        public override void InitialiseAgentProgram()
        {
            throw new NotImplementedException();
        }

        public override void OnAgentMessageNotification(AgentNotificationEventArgs<VacuumCleanerPrecept, VacuumCleanerAction> agentNotificationEventArgs)
        {
            base.OnAgentMessageNotification(agentNotificationEventArgs);
        }

        public override void OnAgentPerformanceMeasureUpdated(AgentPerformanceMeasureUpdatedEventArgs<VacuumCleanerPrecept, VacuumCleanerAction> agentPerformanceMeasureUpdatedEventArgs)
        {
            base.OnAgentPerformanceMeasureUpdated(agentPerformanceMeasureUpdatedEventArgs);
        }
        #endregion

    }
}
