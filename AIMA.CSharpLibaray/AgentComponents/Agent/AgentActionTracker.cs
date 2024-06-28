using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Environment;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
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
    
    public partial class AgentActionTracker< TAgent, TPrecept, TAction> :
        IEnvironmentEventFeedBack< TAgent, TPrecept, TAction>
            where TAction : BaseAction, new()
            where TPrecept : BasePrecept, new()
            
            where TAgent : BaseAgent< TPrecept, TAction>, new()
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
        public void OnAgentActed(EnvironmentAgentActedEventArgs< TAgent, TPrecept, TAction> args)
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
        public void OnAgentAdded(EnvironmentAgentAddedEventArgs< TAgent, TPrecept, TAction> args)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public void OnAgentRemoved(EnvironmentAgentRemovedEventArgs< TAgent, TPrecept, TAction> args)
        {
            throw new NotImplementedException();
        }
    }
}
