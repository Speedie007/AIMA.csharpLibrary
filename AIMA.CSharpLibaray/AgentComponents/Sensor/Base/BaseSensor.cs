using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.AgentComponents.Sensor.Interface;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Sensor.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept">We use the term percept to refer to the content an agent’s sensors are perceiving.</typeparam>
    /// <typeparam name="TAction"></typeparam>
    /// <typeparam name="TPerformanceMeasure"></typeparam>
    public abstract partial class BaseSensor<TPerformanceMeasure,TPrecept, TAction> : ISensor<TPerformanceMeasure, TPrecept, TAction>
        where TPrecept : BasePrecept, new()
        where TAction : BaseAction, new()
        where TPerformanceMeasure: BasePerformanceMeasure, new() 
    {

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public BaseSensor()
        {
            InitialiseSensor();
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
            LinkedDictonarySet<IEnvironmentObject> EnvironmentObjects,
            IAgent<TPerformanceMeasure, TPrecept, TAction> agent);
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public abstract void InitialiseSensor();
        #endregion
    }
}
