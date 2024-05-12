using AIMA.csharpLibrary.Agent.AgentComponents.Base;
using AIMA.csharpLibrary.Agent.EnviromentComponents.Base;

namespace AIMA.csharpLibrary.Agent.EnviromentComponents.EventsArguments
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial class EnviromentAgentAddedEventArgs<TAgent, TPrecept, TAction> : EventArgs
        where TPrecept : class, new()
        where TAction : class, new()
        where TAgent: BaseAgent<TPrecept,TAction>, new()
    {
        #region cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="sourceEnviroment"></param>
        public EnviromentAgentAddedEventArgs(
            TAgent agent,
            BaseEnvironment<TAgent,TPrecept, TAction> sourceEnviroment)
        {
            Agent = agent;
            SourceEnviroment = sourceEnviroment;
        }

        public TAgent Agent { get; }
        public BaseEnvironment<TAgent, TPrecept, TAction> SourceEnviroment { get; }
        #endregion
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial class EnviromentAgentRemovedEventArgs<TAgent,TPrecept, TAction> : EnviromentAgentAddedEventArgs<TAgent, TPrecept, TAction>
        where TPrecept : class, new()
        where TAction : class, new()
        where TAgent : BaseAgent<TPrecept, TAction>, new()
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="sourceEnviroment"></param>
        public EnviromentAgentRemovedEventArgs(TAgent agent, BaseEnvironment<TAgent,TPrecept, TAction> sourceEnviroment) 
            : base(agent, sourceEnviroment)
        {
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial class EnviromentAgentActedEventArgs<TAgent, TPrecept, TAction> : EventArgs 
        where TPrecept : class, new()
        where TAction : class, new()
        where TAgent : BaseAgent<TPrecept, TAction>, new()
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
            BaseEnvironment<TAgent, TPrecept, TAction> sourceEnviroment)
        {
            Agent = agent;
            Percept = percept;
            Action = action;
            SourceEnviroment = sourceEnviroment;
        }

        public TAgent Agent { get; }
        public TPrecept Percept { get; }
        public TAction Action { get; }
        public BaseEnvironment<TAgent, TPrecept, TAction> SourceEnviroment { get; }
        #endregion
    }
}
