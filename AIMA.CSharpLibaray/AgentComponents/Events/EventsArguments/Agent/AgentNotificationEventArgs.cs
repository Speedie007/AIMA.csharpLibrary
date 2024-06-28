﻿using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Agent
{
    /// <summary>
    /// 18 June
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    /// <typeparam name="TPerformanceMeasure"></typeparam>
    public partial class AgentNotificationEventArgs<TPerformanceMeasure,TPrecept, TAction> : BaseAgentEventArgs<TPerformanceMeasure, TPrecept, TAction>
        where TPrecept : BasePrecept, new()
        where TAction : BaseAction, new()
         where TPerformanceMeasure: BasePerformanceMeasure, new() 
    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="agentMessage"></param>
        public AgentNotificationEventArgs(BaseAgent<TPerformanceMeasure,TPrecept, TAction> agent, string agentMessage) : base(agent)
        {
            AgentMessage = agentMessage;
        }

        /// <value>
        /// 
        /// </value>
        public string AgentMessage { get; }
        #endregion
    }
}
