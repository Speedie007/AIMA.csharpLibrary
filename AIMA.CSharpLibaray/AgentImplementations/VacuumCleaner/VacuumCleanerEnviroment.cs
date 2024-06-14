using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner
{
    public partial class VacuumCleanerEnviroment<TAgent, TPrecept, TAction> : BaseEnvironment<TAgent, TPrecept, TAction>
            where TAction : BaseAgentAction, new()
            where TPrecept : BaseAgentPrecept, new()
            where TAgent : BaseAgent<TPrecept, TAction>
    {



        #region Cstor
        public VacuumCleanerEnviroment() : base()
        {
        }
        #endregion
        public override void CreateExogenousChange()
        {
            throw new NotImplementedException();
        }

        public override void ExecuteAgentAction(TAgent agent, TAction action)
        {
            throw new NotImplementedException();
        }

        public override void ExecuteNoOp(TAgent agent)
        {
            throw new NotImplementedException();
        }

        public override TPrecept GetPerceptSeenBy(TAgent agent)
        {
            throw new NotImplementedException();
        }

        //public void AgentMovedToMazeBock(TAgent agent,XYLocation agentNewlocation)
        //{
        //    agent.
        //}
        //public void AgentMovedOutOfMazeBlock()
        //{
        //    Agent = null;
        //}
    }
}
