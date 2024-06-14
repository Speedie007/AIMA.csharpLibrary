using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram;
using AIMA.CSharpLibrary.AgentComponents.Precepts;

namespace AIMA.CSharpLibrary.AgentComponents.Agent.Base.ProblemSolving
{
    public abstract partial class SimpleProblemSolvingAgent<TPrecept, TState, TAction> : SimpleAgent<TPrecept, TAction>
        where TAction : BaseAgentAction, new()
        where TPrecept : BaseAgentPrecept, new()
    {
        protected SimpleProblemSolvingAgent(BaseAgentProgram<IAgent<TPrecept, TAction>, TPrecept, TAction> agentProgram, bool isAlive = true) : base(agentProgram, isAlive)
        {
        }
    }
}
