﻿using AIMA.csharpLibrary.Agent.AgentProgramComponents.Interface;
using AIMA.csharpLibrary.AgentProgram.Agent.Interface;

namespace AIMA.csharpLibrary.Agent.AgentComponents.Base
{
    public abstract partial class BaseAgent<TPrecept, TAction> : IAgent<TPrecept, TAction>
    {
        protected BaseAgent(IAgentProgram<TPrecept, TAction> agentProgram, bool isAlive)
        {
            AgentProgram = agentProgram;
            IsAlive = isAlive;
            ProcessPrecept = new ApplyPreceptHandler(AgentProgram.ApplyCurrentPrecept);
        }

        private delegate TAction? ApplyPreceptHandler(TPrecept percept);


        #region Properties
        private  ApplyPreceptHandler ProcessPrecept { get; }
        protected IAgentProgram<TPrecept, TAction> AgentProgram { get; }
        public bool IsAlive { get; set; }
        #endregion

        public virtual TAction? ActOnPrecept(TPrecept percept)
        {
            if (percept == null && AgentProgram != null)
            {
                return default;
            }
            else { return ProcessPrecept.Invoke(percept) is TAction a ? a : default; }
        }
    }
}