using AIMA.CSharpLibrary.AgentComponents.Actions.Interface;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Actions.Base
{
    /// <summary>
    /// june 24
    /// </summary>
    public abstract partial class BaseActionExecutionModel<TAgent, TPrecept, TAction> : IActionExecutionModel
        where TPrecept : BasePrecept, new()
        where TAction : BaseAction, new()
        where TAgent : BaseAgent<TPrecept, TAction>, new()
    {
        #region Preoperties
        /// <summary>
        /// 
        /// </summary>
        public LinkedDictonarySet<IEnviromentObject> EnviromentObjects { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public TAgent? Agent { get; private set; }
        #endregion

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public BaseActionExecutionModel(TAgent agent, LinkedDictonarySet<IEnviromentObject> enviromentObjects)
        {
            Agent = agent;
            EnviromentObjects = enviromentObjects;
        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        public abstract void ExecuteAction();
        #endregion
    }
}
