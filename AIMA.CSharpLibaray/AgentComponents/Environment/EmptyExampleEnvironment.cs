using AIMA.CSharpLibrary.AgentComponents.Actions;
using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Environment.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Environment;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures;
using AIMA.CSharpLibrary.AgentComponents.Precepts;

namespace AIMA.CSharpLibrary.AgentComponents.Environment
{
    /// <summary>
    /// 
    /// </summary>
    public class EmptyExampleEnvironment : BaseEnvironment<DefaultPerformanceMeasure, ExampleAgent, EmptyExamplePrecept, DefaultAction>
    {


        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public EmptyExampleEnvironment()
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
        public override void OnAgentActed(EnvironmentAgentActedEventArgs<DefaultPerformanceMeasure, ExampleAgent, EmptyExamplePrecept, DefaultAction> args)
        {
            base.OnAgentActed(args);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public override void OnAgentAdded(EnvironmentAgentAddedEventArgs<DefaultPerformanceMeasure, ExampleAgent, EmptyExamplePrecept, DefaultAction> args)
        {
            base.OnAgentAdded(args);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public override void OnAgentRemoved(EnvironmentAgentRemovedEventArgs<DefaultPerformanceMeasure, ExampleAgent, EmptyExamplePrecept, DefaultAction> args)
        {
            base.OnAgentRemoved(args);
        }
    }
}
