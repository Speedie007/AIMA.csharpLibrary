using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.AgentComponents.Sensors.Interface;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Sensors.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public abstract partial class BaseSensor<TPrecept,TAction>: IAgentSensor<TPrecept, TAction>
        where TPrecept : BasePrecept, new()
        where TAction: BaseAction, new()
    {

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public BaseSensor()
        {
                
        }
        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="precept"></param>
        /// <param name="EnvironmentObjects"></param>
        /// <param name="agent"></param>
        /// <returns></returns>
        public abstract TPrecept Poll(
            TPrecept precept,
            LinkedHashSet<IEnvironmentObject> EnvironmentObjects,
            IAgent<TPrecept, TAction> agent);
        #endregion
    }
}
