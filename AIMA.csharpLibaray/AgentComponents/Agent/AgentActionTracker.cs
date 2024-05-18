using AIMA.csharpLibrary.AgentComponents.Agent.Base;
using AIMA.csharpLibrary.AgentComponents.EnviromentComponents.EventsArguments;
using AIMA.csharpLibrary.AgentComponents.EnviromentComponents.Interface;
using System.Text;

namespace AIMA.csharpLibrary.AgentComponents.Agent
{
    public partial class AgentActionTracker<TAgent, TPrecept, TAction> :
        IEnviromentEventFeedBack<TAgent, TPrecept, TAction>
        where TAction : AgentAction
                where TPrecept : AgentPrecept
                where TAgent : BaseAgent<TPrecept, TAction>
    {

        protected StringBuilder actionHistory = new StringBuilder();
        public AgentActionTracker()
        {

        }
        public void OnAgentActed(EnviromentAgentActedEventArgs<TAgent, TPrecept, TAction> args)
        {
            if (actionHistory.Length > 0)
                actionHistory.Append(",");
            actionHistory.Append(args.Action.GetDynamicAttributeValue(args.Action));
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
