using AIMA.CSharp.GUI.Forms.VacuumCleaner;
using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Agents;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept;

namespace AIMA.CSharp.GUI.Factory.Interfaces
{
    public partial  interface IEnviromentFactory
    {
        VacuumCleanerEnviroment<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> BuildSimpleRelexVacuumCleanerEnviroment(frmSimpleReflexVacuumCleaner frm);

        VacuumCleanerEnviroment<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> BuildRelexVacuumCleanerEnviroment(frmReflexVacuumCleaner frm);
    }
}
