using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgramComponents.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgramComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;

namespace AIMA.CSharpLibrary.AgentComponents.Agent
{
    public partial class SimpleAgent<TPrecept, TAction> : BaseAgent<TPrecept, TAction>
         where TAction : BaseAgentAction, new()
         where TPrecept : AgentPrecept, new()
    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentProgram"></param>
        /// <param name="isAlive"></param>
        public SimpleAgent(BaseAgentProgram<TPrecept, TAction> agentProgram, bool isAlive = true) 
            : base(agentProgram, isAlive)
        {
        }

        

        public override TAction ActOnPrecept(TPrecept percept)
        {
            return base.ActOnPrecept(percept);
        }

        public override TPrecept PollAgentSensors(IEnvironment<BaseAgent<TPrecept, TAction>, TPrecept, TAction> currentEnviroment)
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}
