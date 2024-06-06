using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions.Interfaces
{
    public interface IVacuumCleanerMovementAction : IVacuumCleanerAction
    {
        bool CanMoveToNextLocation(XYLocation FromLocation);
        XYLocation GetNextLocation(XYLocation FromLocation);
    }
}
