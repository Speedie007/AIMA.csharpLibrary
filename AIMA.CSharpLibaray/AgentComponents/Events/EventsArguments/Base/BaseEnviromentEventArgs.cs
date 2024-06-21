using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TAgent"></typeparam>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public abstract partial class BaseEnviromentEventArgs<TAgent, TPrecept, TAction> : EventArgs
        where TAction : AbstractAction, new()
        where TPrecept : BasePrecept, new()
        where TAgent : AbstractAgent<TPrecept, TAction>, new()
    {

        #region Cstor
        /// <summary>
        ///
        /// </summary>
        /// <param name="sourceEnviroment"></param>
        protected BaseEnviromentEventArgs(AbstractEnvironment<TAgent, TPrecept, TAction> sourceEnviroment)
        {
            SourceEnviroment = sourceEnviroment;
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public AbstractEnvironment<TAgent, TPrecept, TAction> SourceEnviroment { get; }
    }
}
