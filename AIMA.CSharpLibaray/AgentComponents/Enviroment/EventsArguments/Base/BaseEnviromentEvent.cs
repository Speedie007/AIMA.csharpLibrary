using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts;

namespace AIMA.CSharpLibrary.AgentComponents.Enviroment.EventsArguments.Base
{
    public abstract partial class BaseEnviromentEvent<TAgent, TPrecept, TAction> : EventArgs
        where TAction : BaseAgentAction, new()
                where TPrecept : BaseAgentPrecept, new()
                where TAgent : BaseAgent<TPrecept, TAction>
    {

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceEnviroment"></param>
        protected BaseEnviromentEvent(BaseEnvironment<TAgent, TPrecept, TAction> sourceEnviroment)
        {
            SourceEnviroment = sourceEnviroment;
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public BaseEnvironment<TAgent, TPrecept, TAction> SourceEnviroment { get; }
    }
}
