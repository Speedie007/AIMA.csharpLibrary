﻿using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Environment.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TAgent"></typeparam>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    
    public abstract partial class BaseEnvironmentEventArgs<TAgent, TPrecept, TAction> : EventArgs
        where TAction : BaseAction, new()
        where TPrecept : BasePrecept, new()
          
        where TAgent : BaseAgent< TPrecept, TAction>, new()
    {

        #region Cstor
        /// <summary>
        ///
        /// </summary>
        /// <param name="sourceEnvironment"></param>
        protected BaseEnvironmentEventArgs(BaseEnvironment< TAgent, TPrecept, TAction> sourceEnvironment)
        {
            SourceEnvironment = sourceEnvironment;
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public BaseEnvironment< TAgent, TPrecept, TAction> SourceEnvironment { get; }
    }
}
