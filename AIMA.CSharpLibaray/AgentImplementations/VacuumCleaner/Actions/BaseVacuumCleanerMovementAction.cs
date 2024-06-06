using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions.Interfaces;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions
{
    /// <summary>
    /// <para>Base(Abstract) Enviroment used to represent the domain within wich the agent operates.</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 6 June 2024 - Date Last Updated: 6 June 2024</para>
    /// </summary>
    public abstract partial class BaseVacuumCleanerMovementAction : BaseAgentAction, IVacuumCleanerMovementAction
    {
        public BaseVacuumCleanerMovementAction(string name) : base(name)
        {
        }
        public abstract bool CanMoveToNextLocation(XYLocation FromLocation);
        public abstract XYLocation GetNextLocation(XYLocation FromLocation);
    }
}
