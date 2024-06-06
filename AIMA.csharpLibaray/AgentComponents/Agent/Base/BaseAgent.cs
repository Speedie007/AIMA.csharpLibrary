using AIMA.CSharpLibrary.AgentComponents.Agent.Extentsions;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.AgentProgramComponents.Base;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using NUnit.Framework.Internal.Commands;

namespace AIMA.CSharpLibrary.AgentComponents.Agent.Base
{
    public abstract partial class BaseAgent<TPrecept, TAction> : IAgent<TPrecept, TAction>
         where TAction : BaseAgentAction,new()
         where TPrecept : AgentPrecept,new()
    {

        #region Properties

        protected BaseAgentProgram<TPrecept, TAction> AgentProgram { get; set; }
        public bool IsAlive { get; set; }
        #endregion
        protected BaseAgent() : this(null!, false)
        {
            IsAlive = false;

        }
        protected BaseAgent(BaseAgentProgram<TPrecept, TAction> agentProgram, bool isAlive)
        {
            AgentProgram = agentProgram;
            IsAlive = isAlive;
            //ApplyPreceptFromAgentProgram = new ApplyPreceptHandler(AgentProgram.ApplyCurrentPrecept);
            AgentProgram = agentProgram;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="percept"></param>
        /// <returns></returns>
        public virtual TAction ActOnPrecept(TPrecept percept)
        {
            if (percept == null || AgentProgram == null)
            {
                return (TAction)ActionExtentions.GetNoOperationAction();
            }
            else { return (AgentProgram.PreceptToActionFunc?.Invoke(percept) is TAction a) ? a : (TAction)ActionExtentions.GetNoOperationAction(); }
        }

        public abstract TPrecept PollAgentSensors(IEnvironment<BaseAgent<TPrecept, TAction>, TPrecept, TAction> currentEnviroment);
    }
}
