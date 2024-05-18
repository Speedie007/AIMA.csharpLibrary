using AIMA.csharpLibrary.AgentComponents.Agent;
using AIMA.csharpLibrary.AgentComponents.AgentProgramComponents.Base;

namespace AIMA.csharpLibrary.AgentComponents.AgentProgramComponents.VacuumCleaner
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
