using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Agent.Base.ProblemSolving
{
    public abstract partial class ProblemSolvingAgent<TPrecept, TStates, TAction> : BaseAgent<TPrecept, TAction>
        where TAction : BaseAgentAction, new()
         where TPrecept : BaseAgentPrecept, new()
    {

        public override TAction ActOnPrecept(TPrecept percept)
        {
            return base.ActOnPrecept(percept);
        }

        public override TPrecept PollAgentSensors(LinkedHashSet<IEnvironmentObject> EnvironmentObjects)
        {
            return base.PollAgentSensors(EnvironmentObjects);
        }
    }
}
