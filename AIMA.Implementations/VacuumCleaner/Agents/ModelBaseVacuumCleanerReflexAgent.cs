using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base.Implementations;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Agent;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.PerformanceMeasure;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.Implementations.VacuumCleaner.Actions;
using AIMA.Implementations.VacuumCleaner.Models;
using AIMA.Implementations.VacuumCleaner.PerformanceMeasure;
using AIMA.Implementations.VacuumCleaner.Precept;
using AIMA.Implementations.VacuumCleaner.State;

namespace AIMA.Implementations.VacuumCleaner.Agents
{
    /// <summary>
    /// 22 June
    /// </summary>
    public partial class ModelBaseVacuumCleanerReflexAgent : BaseAgent<VacuumCleanerPerformanceMeasure,VacuumCleanerPrecept, VacuumCleanerAction>
    {

        #region cstor
        /// <summary>
        /// 
        /// </summary>
        public ModelBaseVacuumCleanerReflexAgent()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentProgram"></param>
        /// <param name="performanceMetricStructure"></param>
        /// <param name="isAlive"></param>
        public ModelBaseVacuumCleanerReflexAgent(
            BaseAgentProgram<VacuumCleanerPerformanceMeasure, VacuumCleanerPrecept, VacuumCleanerAction> agentProgram,
            VacuumCleanerPerformanceMeasure performanceMetricStructure,
            bool isAlive) : base(agentProgram, performanceMetricStructure, isAlive)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void ExecuteNoOp()
        {
            throw new NotImplementedException();
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
