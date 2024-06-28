using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Agent;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.PerformanceMeasure;
using AIMA.Implementations.VacuumCleaner.Actions;
using AIMA.Implementations.VacuumCleaner.PerformanceMeasure;
using AIMA.Implementations.VacuumCleaner.Precept;

namespace AIMA.Implementations.VacuumCleaner.Agents
{
    /// <summary>
    /// 16 June
    /// <inheritdoc/>
    /// </summary>
    public partial class TableDrivenVacuumCleanerAgent : BaseAgent<VacuumCleanerPerformanceMeasure, VacuumCleanerPrecept, VacuumCleanerAction>
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
        /// <param name="isAlive"><inheritdoc/></param>
        /// <param name="performanceMetricStructure"></param>
        public TableDrivenVacuumCleanerAgent(
            BaseAgentProgram<VacuumCleanerPerformanceMeasure, VacuumCleanerPrecept, VacuumCleanerAction> agentProgram,
            VacuumCleanerPerformanceMeasure performanceMetricStructure,
            bool isAlive) : base(agentProgram, performanceMetricStructure, isAlive)
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
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void InitialiseAgentProgram()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentNotificationEventArgs"></param>
        public override void OnAgentMessageNotification(AgentNotificationEventArgs<VacuumCleanerPerformanceMeasure, VacuumCleanerPrecept, VacuumCleanerAction> agentNotificationEventArgs)
        {
            base.OnAgentMessageNotification(agentNotificationEventArgs);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentPerformanceMeasureUpdatedEventArgs"></param>
        public override void OnAgentPerformanceMeasureUpdated(AgentPerformanceMeasureUpdatedEventArgs<VacuumCleanerPerformanceMeasure, VacuumCleanerPrecept, VacuumCleanerAction> agentPerformanceMeasureUpdatedEventArgs)
        {
            base.OnAgentPerformanceMeasureUpdated(agentPerformanceMeasureUpdatedEventArgs);
        }
        #endregion

    }
}
