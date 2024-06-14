using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.VacuumCleaner
{
    public partial class VacuumCleanerTableDrivenAgentProgram<TAgent, TPrecept, TAction> : TableDrivenAgentProgram<TAgent, TPrecept, TAction>
        where TAction : BaseAgentAction, new()
        where TPrecept : BaseAgentPrecept, new()
        where TAgent : BaseAgent<TPrecept, TAction>, new()
    {
        #region cstor

        public VacuumCleanerTableDrivenAgentProgram(Dictionary<List<TPrecept>, TAction> perceptsToActionMap) : base(perceptsToActionMap)
        {
        }

        public override void Initialize()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
