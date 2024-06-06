using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Base;

namespace AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.EventsArguments
{
    public abstract partial class BaseEnviromentEvent<TAgent, TPrecept, TAction> : EventArgs
        where TAction : BaseAgentAction, new()
                where TPrecept : AgentPrecept, new()
                where TAgent : BaseAgent<TPrecept, TAction>
    {
        protected BaseEnviromentEvent(BaseEnvironment<TAgent, TPrecept, TAction> sourceEnviroment)
        {
            SourceEnviroment = sourceEnviroment;
        }
        #region Cstor

        #endregion

        public BaseEnvironment<TAgent, TPrecept, TAction> SourceEnviroment { get; }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial class EnviromentAgentAddedEventArgs<TAgent, TPrecept, TAction> : BaseEnviromentEvent<TAgent, TPrecept, TAction>
        where TAction : BaseAgentAction, new()
        where TPrecept : AgentPrecept, new()    
        where TAgent : BaseAgent<TPrecept, TAction>
    {
        #region cstor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="sourceEnviroment"></param>
        public EnviromentAgentAddedEventArgs(
            TAgent agentAdded,
            BaseEnvironment<TAgent, TPrecept, TAction> sourceEnviroment) : base(sourceEnviroment)
        {
            AgentAdded = agentAdded;

        }

        public TAgent AgentAdded { get; }
        #endregion
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial class EnviromentAgentRemovedEventArgs<TAgent, TPrecept, TAction> : BaseEnviromentEvent<TAgent, TPrecept, TAction>
        where TAction : BaseAgentAction, new()
        where TPrecept : AgentPrecept, new()
        where TAgent : BaseAgent<TPrecept, TAction>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="sourceEnviroment"></param>
        public EnviromentAgentRemovedEventArgs(TAgent agentRemoved, BaseEnvironment<TAgent, TPrecept, TAction> sourceEnviroment)
            : base(sourceEnviroment)
        {
            AgentRemoved = agentRemoved;
        }
        public TAgent AgentRemoved { get; }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial class EnviromentAgentActedEventArgs<TAgent, TPrecept, TAction> : BaseEnviromentEvent<TAgent, TPrecept, TAction>
        where TAction : BaseAgentAction, new()
        where TPrecept : AgentPrecept, new()
        where TAgent : BaseAgent<TPrecept, TAction>
    {
        #region cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="percept"></param>
        /// <param name="action"></param>
        /// <param name="sourceEnviroment"></param>
        public EnviromentAgentActedEventArgs(
            TAgent agent,
            TPrecept percept,
            TAction action,
            BaseEnvironment<TAgent, TPrecept, TAction> sourceEnviroment) : base(sourceEnviroment)
        {
            Agent = agent;
            Percept = percept;
            Action = action;

        }

        public TAgent Agent { get; }
        public TPrecept Percept { get; }
        public TAction Action { get; }

        #endregion
    }
}
