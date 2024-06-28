using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Sensor.Interface
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    /// <typeparam name="TPerformanceMeasure"></typeparam>
    public partial interface ISensor<TPerformanceMeasure, TPrecept, TAction>
        where TPrecept : BasePrecept, new()
        where TAction : BaseAction, new()
         where TPerformanceMeasure: BasePerformanceMeasure, new()
    {
        /// <summary>
        /// 
        /// </summary>
        void InitialiseSensor();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        TPrecept Poll(TPrecept precept, LinkedDictonarySet<IEnvironmentObject> EnvironmentObjects, IAgent<TPerformanceMeasure, TPrecept, TAction> agent);
    }
}
