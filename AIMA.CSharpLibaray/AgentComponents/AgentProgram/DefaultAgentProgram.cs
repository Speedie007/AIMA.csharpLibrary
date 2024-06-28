using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DefaultAgentProgram<TPrecept, TAction> : BaseAgentProgram< TPrecept, TAction>
        where TAction : BaseAction, new()
        where TPrecept : BasePrecept, new()
         
    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public DefaultAgentProgram() : base()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public override void InitializeAgentProgramComponents()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="environmentObjects"></param>
        /// <param name="action"></param>
        /// <param name="agent"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void ProcessAgentAction(LinkedDictonarySet<IEnvironmentObject> environmentObjects, TAction action, BaseAgent< TPrecept, TAction> agent)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="percept">Agent Precept.</param>
        /// <remarks>In this example the precept is empty.</remarks>
        /// <returns>Default ActionExecuted => which is No Operation ActionExecuted. The agent will do thing.</returns>
        public override TAction ProcessAgentFunctionAsync(TPrecept percept)
        {
            return new();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="EnvironmentObjects"></param>
        /// <param name="agent"></param>
        /// <returns></returns>
        protected override TPrecept ProcessSensors(LinkedDictonarySet<IEnvironmentObject> EnvironmentObjects, IAgent< TPrecept, TAction> agent)
        {
            return base.ProcessSensors(EnvironmentObjects, agent);
        }
        #endregion


    }
}
