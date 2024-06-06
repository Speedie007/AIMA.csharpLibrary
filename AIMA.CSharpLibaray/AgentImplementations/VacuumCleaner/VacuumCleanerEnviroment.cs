using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Base;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner
{
    public partial class VacuumCleanerEnviroment<TAgent, TPrecept, TAction> : BaseEnvironment<TAgent, TPrecept, TAction>
            where TAction : BaseAgentAction, new()
            where TPrecept : AgentPrecept, new()
            where TAgent : BaseAgent<TPrecept, TAction>
    {



        #region Cstor
        public VacuumCleanerEnviroment() : base()
        {
        }
        #endregion
        public override void CreateExogenousChange()
        {
            throw new NotImplementedException();
        }

        public override void Execute(TAgent agent, TAction action)
        {
            throw new NotImplementedException();
        }

        public override void ExecuteNoOp(TAgent agent)
        {
            throw new NotImplementedException();
        }

        public override TPrecept GetPerceptSeenBy(TAgent agent)
        {
            throw new NotImplementedException();
        }
    }
}
