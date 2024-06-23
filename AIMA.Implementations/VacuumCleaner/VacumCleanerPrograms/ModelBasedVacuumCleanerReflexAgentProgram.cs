using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base.Implementations;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Models;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.State;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.VacumCleanerPrograms
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ModelBasedVacuumCleanerReflexAgentProgram : BaseModelBasedReflexAgentProgram<VacuumCleanerPrecept, VacuumCleanerAction, VacuumCleanerState, VacuumCleanerModel>
    {
        public ModelBasedVacuumCleanerReflexAgentProgram()
        {
        }

        public override void InitializeAgentProgramComponents()
        {
            throw new NotImplementedException();
        }

        protected override VacuumCleanerState UpdateState(
            VacuumCleanerState state,
            VacuumCleanerAction action,
            VacuumCleanerPrecept percept,
            VacuumCleanerModel model)
        {
            throw new NotImplementedException();
        }
    }
}
