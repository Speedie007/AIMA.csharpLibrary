using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.VacumCleanerPrograms;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Agents
{
    public partial class ReflexVacuumCleanerAgent : BaseAgent<VacuumCleanerPrecept, VacuumCleanerAction>
    {
        public ReflexVacuumCleanerAgent() : base(new ReflexAgentProgram(), false)
        {

        }

        public ReflexVacuumCleanerAgent(BaseAgentProgram<IAgent<VacuumCleanerPrecept, VacuumCleanerAction>, VacuumCleanerPrecept, VacuumCleanerAction>? agentProgram, bool isAlive) : base(agentProgram, isAlive)
        {
        }

        public override VacuumCleanerAction ActOnPrecept(VacuumCleanerPrecept percept)
        {
            return base.ActOnPrecept(percept);
        }

        public override VacuumCleanerPrecept PollAgentSensors(LinkedHashSet<IEnvironmentObject> EnvironmentObjects)
        {
            return base.PollAgentSensors(EnvironmentObjects);
        }

        //public override VacuumCleanerPrecept PollAgentSensors(LinkedHashSet<IEnvironmentObject> EnvironmentObjects)
        //{
        //    if (EnvironmentObjects != null)
        //    return AgentProgram.SensorPollingFunc.Invoke(EnvironmentObjects);

        //}
    }
}
