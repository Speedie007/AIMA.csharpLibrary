using AIMA.csharpLibrary.Agent.AgentComponents.Base;
using AIMA.csharpLibrary.Agent.AgentProgramComponents.Interface;

namespace AIMA.csharpLibrary.Agent.AgentComponents
{
    public partial class SimpleAgent<TPrecept, TAction> : BaseAgent<TPrecept, TAction>
    //where TAction : new()
    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentProgram"></param>
        /// <param name="isAlive"></param>
        public SimpleAgent(IAgentProgram<TPrecept, TAction> agentProgram, bool isAlive = true) : base(agentProgram, isAlive)
        {
        }
        #endregion
    }
}
