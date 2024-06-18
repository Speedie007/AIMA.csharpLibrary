using AIMA.CSharpLibrary.AgentComponents.Actions;
using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Enviroment;
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public override void OnAgentActed(EnviromentAgentActedEventArgs<ExampleAgent, EmptyPrecept, EmptyAction> args)
        {
            base.OnAgentActed(args);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public override void OnAgentAdded(EnviromentAgentAddedEventArgs<ExampleAgent, EmptyPrecept, EmptyAction> args)
        {
            base.OnAgentAdded(args);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public override void OnAgentRemoved(EnviromentAgentRemovedEventArgs<ExampleAgent, EmptyPrecept, EmptyAction> args)
        {
            base.OnAgentRemoved(args);
        }
    }
}
