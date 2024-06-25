using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Interface;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Agents;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.Implementations.VacuumCleaner.Actions.ExecutionModel
{
    internal class temp : BaseActionExecutionModel<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction>
    {
        public temp(ReflexVacuumCleanerAgent agent, LinkedDictonarySet<IEnviromentObject> enviromentObjects) : base(agent, enviromentObjects)
        {
        }

        public override void ExecuteAction()
        {
            throw new NotImplementedException();
        }
    }
}
