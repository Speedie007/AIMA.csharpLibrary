using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Agent.Base.ProblemSolving
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <typeparam name="TPrecept"><inheritdoc/><inheritdoc/></typeparam>
    /// <typeparam name="TStates"><inheritdoc/></typeparam>
    /// <typeparam name="TAction"><inheritdoc/></typeparam>
    public abstract partial class AbstractProblemSolvingAgent<TPrecept, TStates, TAction> : AbstractAgent<TPrecept, TAction>
        where TAction : AbstractAction, new()
         where TPrecept : BasePrecept, new()
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="agentProgram"><inheritdoc/></param>
        /// <param name="performanceMeasure"><inheritdoc/></param>
        /// <param name="isAlive"><inheritdoc/></param>
        protected AbstractProblemSolvingAgent(
            AbstractAgentProgram<TPrecept, TAction> agentProgram,
            BasePerformaceMeasure performanceMeasure,
            bool isAlive) : base(agentProgram, performanceMeasure, isAlive)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="percept"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public override TAction ProcessAgentFunction(TPrecept percept)
        {
            return base.ProcessAgentFunction(percept);
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="EnvironmentObjects"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public override TPrecept PollAgentSensors(LinkedHashSet<IEnvironmentObject> EnvironmentObjects)
        {
            return base.PollAgentSensors(EnvironmentObjects);
        }




    }
}
