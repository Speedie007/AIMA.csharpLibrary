using AIMA.CSharpLibrary.AgentComponents.Actions;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts;

namespace AIMA.CSharpLibrary.AgentComponents.Agent
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public partial class ExampleAgent : BaseAgent<EmptyExamplePrecept, DefaultAction>
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ExampleAgent() : base()
        {
        }
        /// <inheritdoc/>
        public ExampleAgent(BaseAgentProgram<EmptyExamplePrecept, DefaultAction> agentProgram, BasePerformanceMeasure performanceMeasure, bool isAlive) : base(agentProgram, performanceMeasure, isAlive)
        {
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
        public override void ExecuteAgentAction(DefaultAction action)
        {

        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override void InitialiseAgentProgram()
        {
        }
    }
}
