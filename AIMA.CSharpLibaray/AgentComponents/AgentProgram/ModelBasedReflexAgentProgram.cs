using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts;
using AIMA.CSharpLibrary.Common.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram
{
    public partial class ModelBasedReflexAgentProgram<TAgent, TPrecept, TAction> : BaseAgentProgram<TAgent, TPrecept, TAction>
        where TPrecept : BaseAgentPrecept, new()
        where TAction : BaseAgentAction, new()
        where TAgent : BaseAgent<TPrecept, TAction>, new()
    {

        #region Properties
        /// <summary>
        /// Agenbt action, the most recent action, initially none
        /// </summary>
        public TAction LastActionExecuted { get; set; }
        #endregion
        public ModelBasedReflexAgentProgram()
        {
        }

        public override void Initialize()
        {
            throw new NotImplementedException();
        }

        public override TAction ProcessAgentPecept(TPrecept percept)
        {
            throw new NotImplementedException();
        }

       
    }
}
