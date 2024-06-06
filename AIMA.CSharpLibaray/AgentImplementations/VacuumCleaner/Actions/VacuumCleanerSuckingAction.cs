using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions.Interfaces;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions
{
    public class VacuumCleanerSuckAction : BaseAgentAction, IVacuumCleanerAction
    {
        public VacuumCleanerSuckAction() : base(nameof(VacuumCleanerSuckAction))
        {

        }

        public override Type DynamicAtrributeType()
        {
            
            return GetType();
        }
    }
}
