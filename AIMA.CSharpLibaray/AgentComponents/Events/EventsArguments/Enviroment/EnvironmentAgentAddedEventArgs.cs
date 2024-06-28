using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Environment.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Environment
{
    /// <summary>
    /// 16 June
    /// </summary>
    /// <typeparam name="TAgent"></typeparam>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    
    public partial class EnvironmentAgentAddedEventArgs<TAgent, TPrecept, TAction> : BaseEnvironmentEventArgs< TAgent, TPrecept, TAction>
        where TAction : BaseAction, new()
        where TPrecept : BasePrecept, new()
          
        where TAgent : BaseAgent<  TPrecept, TAction>, new()
    {
        #region cstor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentAdded"></param>
        /// <param name="sourceEnvironment"></param>
        public EnvironmentAgentAddedEventArgs(
            TAgent agentAdded,
            BaseEnvironment<TAgent, TPrecept, TAction> sourceEnvironment) : base(sourceEnvironment)
        {
            AgentAdded = agentAdded;

        }


        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public TAgent AgentAdded { get; }
        #endregion
    }

}
