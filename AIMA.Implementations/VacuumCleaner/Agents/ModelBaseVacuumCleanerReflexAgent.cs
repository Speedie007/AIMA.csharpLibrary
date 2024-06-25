using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base.Implementations;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Agent;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.PerformaneMeasure;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Models;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.State;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Agents
{
    /// <summary>
    /// 22 June
    /// </summary>
    public partial class ModelBaseVacuumCleanerReflexAgent : BaseAgent<VacuumCleanerPrecept, VacuumCleanerAction>
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
        /// <param name="performanceMeasure"></param>
        /// <param name="isAlive"></param>
        public ModelBaseVacuumCleanerReflexAgent(
            BaseModelBasedReflexAgentProgram<VacuumCleanerPrecept, VacuumCleanerAction,VacuumCleanerState, VacuumCleanerModel> agentProgram,
            BasePerformanceMeasure performanceMeasure,
            bool isAlive) : base(agentProgram, performanceMeasure, isAlive)
        {
        }

        public override void ExecuteNoOp()
        {
            throw new NotImplementedException();
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
