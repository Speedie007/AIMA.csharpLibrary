using AIMA.CSharpLibrary.AgentComponents.Actions;
using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts;

namespace AIMA.CSharpLibrary.AgentComponents.Enviroment
{
    /// <summary>
    /// 
    /// </summary>
    public class EmptyExampleEnviroment : BaseEnvironment<ExampleAgent, EmptyPrecept, EmptyAction>
    {


        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public EmptyExampleEnviroment()
        {
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void CreateExogenousChange()
        {
            throw new NotImplementedException();
        }

        //public override void ExecuteAgentAction(ExampleAgent agent, EmptyAction action)
        //{
        //    throw new NotImplementedException();
        //}

        //public override void ExecuteNoOp(ExampleAgent agent)
        //{
        //    throw new NotImplementedException();
        //}

        //public override EmptyPrecept GetPerceptSeenBy(ExampleAgent agent)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
