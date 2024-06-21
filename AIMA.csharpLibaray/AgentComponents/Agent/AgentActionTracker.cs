using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Enviroment;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using System.Text;

namespace AIMA.CSharpLibrary.AgentComponents.Agent
{
    /// <summary>
    /// 16 June
    /// </summary>
    /// <typeparam name="TAgent"></typeparam>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial class AgentActionTracker<TAgent, TPrecept, TAction> :
        IEnviromentEventFeedBack<TAgent, TPrecept, TAction>
            where TAction : AbstractAction,new()
            where TPrecept : BasePrecept, new()
            where TAgent : AbstractAgent<TPrecept, TAction>
    {
        /// <summary>
        /// 
        /// </summary>
        protected StringBuilder actionHistory = new();
        /// <summary>
        /// 
        /// </summary>
        public AgentActionTracker()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void OnAgentActed(EnviromentAgentActedEventArgs<TAgent, TPrecept, TAction> args)
        {
            throw new NotImplementedException();
            //if (actionHistory.Length > 0)
            //    actionHistory.Append(",");
            //actionHistory.Append(args.ActionExecuted.GetAttributeValue(args.ActionExecuted));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void OnAgentAdded(EnviromentAgentAddedEventArgs<TAgent, TPrecept, TAction> args)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void OnAgentRemoved(EnviromentAgentRemovedEventArgs<TAgent, TPrecept, TAction> args)
        {
            throw new NotImplementedException();
        }
    }
}
