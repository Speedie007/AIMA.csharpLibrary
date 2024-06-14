using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Agent
{
    public partial class SimpleAgent<TPrecept, TAction> : BaseAgent<TPrecept, TAction>
         where TAction : BaseAgentAction, new()
         where TPrecept : BaseAgentPrecept, new()
    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentProgram"></param>
        /// <param name="isAlive"></param>
        public SimpleAgent(BaseAgentProgram<IAgent<TPrecept,TAction>,TPrecept, TAction> agentProgram, bool isAlive = true) 
            : base(agentProgram, isAlive)
        {
        }

        

        public override TAction ActOnPrecept(TPrecept percept)
        {
            return base.ActOnPrecept(percept);
        }

        public override TPrecept PollAgentSensors(LinkedHashSet<IEnvironmentObject> EnvironmentObjects)
        {
            throw new NotImplementedException();
        }



        #endregion
    }
}
