using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram
{
    public partial class SimpleReflexAgentProgram<TAgent, TPrecept, TAction> : BaseAgentProgram<TAgent, TPrecept, TAction>
        where TAction : BaseAgentAction, new()
        where TPrecept : BaseAgentPrecept, new()
        where TAgent : BaseAgent<TPrecept, TAction>, new()
    {


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
