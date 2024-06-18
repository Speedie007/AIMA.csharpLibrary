using AIMA.CSharpLibrary.AgentComponents.Actions;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base.ProblemSolving;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Agent
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public partial class ExampleAgent : BaseAgent<EmptyPrecept, EmptyAction>
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ExampleAgent() : base()
        {
        }
        /// <inheritdoc/>
        public ExampleAgent(BaseAgentProgram<EmptyPrecept, EmptyAction> agentProgram, BasePerformaceMeasure performanceMeasure, bool isAlive) : base(agentProgram, performanceMeasure, isAlive)
        {
        }

        /// <inheritdoc/>
        public override EmptyPrecept PollAgentSensors(LinkedHashSet<IEnvironmentObject> EnvironmentObjects)
        {
            return base.PollAgentSensors(EnvironmentObjects);
        }

        /// <inheritdoc/>
        public override EmptyAction DeriveAgentActionBasedOnPrecept(EmptyPrecept percept)
        {
            return base.DeriveAgentActionBasedOnPrecept(percept);
        }
        /// <inheritdoc/>
        public override void ExecuteNoOp()
        {
            //Does Nothing by default.
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="action"><inheritdoc/></param>
        public override void ExecuteAgentAction(EmptyAction action)
        {
            
        }
    }
}
