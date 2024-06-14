using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Precepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.EventsArguments.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Enviroment.EventsArguments
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial class EnviromentAgentActedEventArgs<TAgent, TPrecept, TAction> : BaseEnviromentEvent<TAgent, TPrecept, TAction>
        where TAction : BaseAgentAction, new()
        where TPrecept : BaseAgentPrecept, new()
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
        #endregion

        #region Properties
        public TAgent Agent { get; }
        public TPrecept Percept { get; }
        public TAction Action { get; }
        #endregion
    }
}
