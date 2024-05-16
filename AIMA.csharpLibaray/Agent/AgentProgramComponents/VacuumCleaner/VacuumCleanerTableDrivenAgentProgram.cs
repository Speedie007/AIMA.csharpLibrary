using AIMA.csharpLibrary.Agent.AgentComponents;
using AIMA.csharpLibrary.Agent.AgentProgramComponents.Base;

namespace AIMA.csharpLibrary.Agent.AgentProgramComponents.VacuumCleaner
{
    public partial class VacuumCleanerTableDrivenAgentProgram<TPrecept, TAction> : TableDrivenAgentProgram<TPrecept, TAction>
        where TAction : AgentAction
        where TPrecept : AgentPrecept
    {
        #region cstor
        public VacuumCleanerTableDrivenAgentProgram(Dictionary<List<TPrecept>, TAction> table) : base(table)
        {
        }
        #endregion

    }
}
