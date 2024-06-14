using AIMA.CSharpLibrary.AgentComponents.Agent.Extentsions;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Agent.Base
{
    public abstract partial class BaseAgent<TPrecept, TAction> : IAgent<TPrecept, TAction>
         where TAction : BaseAgentAction, new()
         where TPrecept : BaseAgentPrecept, new()
    {

        #region Properties

        protected BaseAgentProgram<IAgent<TPrecept,TAction>,TPrecept, TAction>? AgentProgram { get; set; }
        public bool IsAlive { get; set; }
        #endregion
        protected BaseAgent() : this(null, false)
        {
            IsAlive = false;

        }
        protected BaseAgent(BaseAgentProgram<IAgent<TPrecept, TAction>,TPrecept, TAction>? agentProgram, bool isAlive)
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
            else { return (AgentProgram.PreceptToActionFunc?.Invoke(percept) is TAction agentAction) ? agentAction : (TAction)ActionExtentions.GetNoOperationAction(); }
        }

        public virtual TPrecept PollAgentSensors(LinkedHashSet<IEnvironmentObject> EnvironmentObjects)
        {
            return AgentProgram.SensorPollingFunc?.Invoke(EnvironmentObjects,this) is TPrecept agentPrecept ? agentPrecept : new();


        }
    }
}
