using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base.Implementations;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Interface;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Models;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.State;
using AIMA.CSharpLibrary.Common.DataStructure;

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

        public override void ProcessAgentAction(LinkedDictonarySet<IEnviromentObject> enviromentObjects, VacuumCleanerAction action, BaseAgent<VacuumCleanerPrecept, VacuumCleanerAction> agent)
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
