using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.AgentProgramComponents.Base;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgramComponents.VacuumCleaner
{
    public partial class VacuumCleanerTableDrivenAgentProgram<TPrecept, TAction> : TableDrivenAgentProgram<TPrecept, TAction>
        where TAction : BaseAgentAction
        where TPrecept : AgentPrecept
    {
        #region cstor
        public VacuumCleanerTableDrivenAgentProgram(Dictionary<List<TPrecept>, TAction> table) : base(table)
        {
        }

        public override void Initialize()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
