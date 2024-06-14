using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts;
using AIMA.CSharpLibrary.AgentComponents.Sensors.Interface;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Sensors.Base
{
    public abstract partial class BaseSensor<TPrecept,TAction>: IAgentSensor<TPrecept, TAction>
        where TPrecept : BaseAgentPrecept, new()
        where TAction: BaseAgentAction, new()
    {

        #region Cstor
        public BaseSensor()
        {
                
        }


        #endregion

        #region Methods


        public abstract TPrecept Poll(TPrecept precept, LinkedHashSet<IEnvironmentObject> EnvironmentObjects, IAgent<TPrecept, TAction> agent);
        #endregion
    }
}
