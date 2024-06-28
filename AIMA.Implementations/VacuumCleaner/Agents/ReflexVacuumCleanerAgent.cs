using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Agent;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.PerformanceMeasure;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.Implementations.VacuumCleaner.Actions;
using AIMA.Implementations.VacuumCleaner.PerformanceMeasure;
using AIMA.Implementations.VacuumCleaner.Precept;

namespace AIMA.Implementations.VacuumCleaner.Agents
{
    /// <summary>
    /// <para>Artificial Intelligence A Modern Approach (3rd Edition): Figure 2.8, page 48.</para>
    /// 
    /// 16 June
    /// </summary>
    public partial class ReflexVacuumCleanerAgent : BaseAgent<VacuumCleanerPerformanceMeasure, VacuumCleanerPrecept, VacuumCleanerAction>
    {
       
        #region Cstor
         /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ReflexVacuumCleanerAgent() : this(
            new DefaultAgentProgram<VacuumCleanerPerformanceMeasure, VacuumCleanerPrecept, VacuumCleanerAction>(),
            new VacuumCleanerPerformanceMeasure(),
            true)
        {
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="agentProgram"><inheritdoc/></param>
        /// <param name="isAlive"><inheritdoc/></param>
        /// <param name="performanceMetricStructure"></param>
        public ReflexVacuumCleanerAgent(
            BaseAgentProgram<VacuumCleanerPerformanceMeasure, VacuumCleanerPrecept, VacuumCleanerAction> agentProgram,
            VacuumCleanerPerformanceMeasure performanceMetricStructure,
            bool isAlive) : base(agentProgram, performanceMetricStructure, isAlive)
        {
        }
        #endregion

        #region Methods
        /// <inheritdoc/>
        public override void ExecuteNoOp()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override void InitialiseAgentProgram()
        {
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
