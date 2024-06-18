using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Agents
{
    /// <summary>
    /// <para>Artificial Intelligence A Modern Approach (3rd Edition): Figure 2.8, page 48.</para>
    /// 
    /// 16 june
    /// </summary>
    public partial class ReflexVacuumCleanerAgent : BaseAgent<VacuumCleanerPrecept, VacuumCleanerAction>
    {
        #region Cstor
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ReflexVacuumCleanerAgent() : this(
            new DefaultAgentProgram<VacuumCleanerPrecept, VacuumCleanerAction>(),
            new DefaultPerformanceMeasure(),
            true)
        { }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="agentProgram"><inheritdoc/></param>
        /// <param name="performaceMeasure"><inheritdoc/></param>
        /// <param name="isAlive"><inheritdoc/></param>
        public ReflexVacuumCleanerAgent(
            BaseAgentProgram<VacuumCleanerPrecept, VacuumCleanerAction> agentProgram,
            BasePerformaceMeasure performaceMeasure,
            bool isAlive) : base(agentProgram, performaceMeasure, isAlive)
        {
        }
        #endregion

        #region Methods
        /// <inheritdoc/>
        public override void ExecuteAgentAction(VacuumCleanerAction action)
        {
            throw new NotImplementedException();
        }
        /// <inheritdoc/>
        public override void ExecuteNoOp()
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
