using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions.Interfaces;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions
{
    public abstract partial class BaseVacuumCleanerMovementAction : BaseAgentAction, IVacuumCleanerMovementAction
    {
        public BaseVacuumCleanerMovementAction(string name) : base(name)
        {
        }
        public abstract bool CanMoveToNextLocation(XYLocation FromLocation);
        public abstract XYLocation GetNextLocation(XYLocation FromLocation);
    }
}
