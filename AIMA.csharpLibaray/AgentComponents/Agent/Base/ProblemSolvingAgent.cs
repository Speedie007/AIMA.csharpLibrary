using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;

namespace AIMA.CSharpLibrary.AgentComponents.Agent.Base
{
    public partial class ProblemSolvingAgent<TPrecept, TStates, TAction> : BaseAgent<TPrecept, TAction>
        where TAction : BaseAgentAction, new()
         where TPrecept : AgentPrecept, new()
    {
        public override TPrecept PollAgentSensors(IEnvironment<BaseAgent<TPrecept, TAction>, TPrecept, TAction> currentEnviroment)
        {
            throw new NotImplementedException();
        }
    }
}
