using AIMA.csharpLibrary.AgentComponents.Agent.Base;
using AIMA.csharpLibrary.AgentComponents.AgentProgramComponents.Interface;

namespace AIMA.csharpLibrary.AgentComponents.Agent
{
    public partial class SimpleAgent<TPrecept, TAction> : BaseAgent<TPrecept, TAction>
        where TAction : AgentAction
        where TPrecept : AgentPrecept
    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentProgram"></param>
        /// <param name="isAlive"></param>
        public SimpleAgent(IAgentProgram<TPrecept, TAction> agentProgram, bool isAlive = true) 
            : base(agentProgram, isAlive)
        {
        }

        public override TAction? ActOnPrecept(TPrecept percept)
        {
            return base.ActOnPrecept(percept);
        }


        #endregion
    }
}
