using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Sensors.Interface
{
   /// <summary>
   /// 
   /// </summary>
   /// <typeparam name="TPrecept"></typeparam>
    public partial interface IAgentSensor<TPrecept, TAction>
        where TPrecept : BaseAgentPrecept, new()
        where TAction: BaseAgentAction, new()
    {
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
        TPrecept Poll(TPrecept precept, LinkedHashSet<IEnvironmentObject> EnvironmentObjects, IAgent<TPrecept,TAction> agent);
    }
}
