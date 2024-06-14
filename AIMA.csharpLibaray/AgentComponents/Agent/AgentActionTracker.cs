using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.EventsArguments;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts;
using System.Text;

namespace AIMA.CSharpLibrary.AgentComponents.Agent
{
    public partial class AgentActionTracker<TAgent, TPrecept, TAction> :
        IEnviromentEventFeedBack<TAgent, TPrecept, TAction>
            where TAction : BaseAgentAction,new()
            where TPrecept : BaseAgentPrecept, new()
            where TAgent : BaseAgent<TPrecept, TAction>
    {

        protected StringBuilder actionHistory = new();
        public AgentActionTracker()
        {

        }
        public void OnAgentActed(EnviromentAgentActedEventArgs<TAgent, TPrecept, TAction> args)
        {
            throw new NotImplementedException();
            //if (actionHistory.Length > 0)
            //    actionHistory.Append(",");
            //actionHistory.Append(args.Action.GetAttributeValue(args.Action));
        }

        public void OnAgentAdded(EnviromentAgentAddedEventArgs<TAgent, TPrecept, TAction> args)
        {
            throw new NotImplementedException();
        }

        public void OnAgentRemoved(EnviromentAgentRemovedEventArgs<TAgent, TPrecept, TAction> args)
        {
            throw new NotImplementedException();
        }
    }
}
