﻿using AIMA.CSharpLibrary.AgentComponents.Actions;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts;

namespace AIMA.CSharpLibrary.AgentComponents.Agent
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public partial class ExampleAgent : AbstractAgent<EmptyExamplePrecept, DefaultAction>
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ExampleAgent() : base()
        {
        }
        /// <inheritdoc/>
        public ExampleAgent(AbstractAgentProgram<EmptyExamplePrecept, DefaultAction> agentProgram, BasePerformaceMeasure performanceMeasure, bool isAlive) : base(agentProgram, performanceMeasure, isAlive)
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
    }
}
