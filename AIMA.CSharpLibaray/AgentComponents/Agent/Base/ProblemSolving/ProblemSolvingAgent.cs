using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Agent.Base.ProblemSolving
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"><inheritdoc/></typeparam>
    /// <typeparam name="TStates"><inheritdoc/></typeparam>
    /// <typeparam name="TAction"><inheritdoc/></typeparam>
    public abstract partial class ProblemSolvingAgent<TPrecept, TStates, TAction> : BaseAgent<TPrecept, TAction>
        where TAction : BaseAction, new()
         where TPrecept : BasePrecept, new()
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="percept"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public override TAction DeriveAgentActionBasedOnPrecept(TPrecept percept)
        {
            return base.DeriveAgentActionBasedOnPrecept(percept);
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
