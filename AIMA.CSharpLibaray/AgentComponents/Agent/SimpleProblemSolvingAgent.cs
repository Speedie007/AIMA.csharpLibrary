using AIMA.CSharpLibrary.AgentComponents.AgentProgramComponents.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgramComponents.Interface;

namespace AIMA.CSharpLibrary.AgentComponents.Agent
{
    public abstract partial class SimpleProblemSolvingAgent<TPrecept, TState, TAction> : SimpleAgent<TPrecept, TAction>
        where TAction : BaseAgentAction, new()
        where TPrecept : AgentPrecept, new()
    {
        protected SimpleProblemSolvingAgent(BaseAgentProgram<TPrecept, TAction> agentProgram, bool isAlive = true) : base(agentProgram, isAlive)
        {
        }
    }
}
