using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Sensors.Interface
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial interface IAgentSensor<TPrecept, TAction>
        where TPrecept : BasePrecept, new()
        where TAction: BaseAction, new()
    {
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
        TPrecept Poll(TPrecept precept, LinkedHashSet<IEnvironmentObject> EnvironmentObjects, IAgent<TPrecept,TAction> agent);
    }
}
