using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DefaultAgentProgram<TPrecept, TAction> : BaseAgentProgram<TPrecept, TAction>
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
        public override void Initialize()
        {
         
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="percept">Agent Precept</param>
        /// <remarks>In this example the precept is emtpy</remarks>
        /// <returns>Default Action => which is No Operation Action. The agent will do thing.</returns>
        public override TAction ProcessAgentPecept(TPrecept percept)
        {
            return new();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="EnvironmentObjects"></param>
        /// <param name="agent"></param>
        /// <returns></returns>
        protected override TPrecept ProcessSensors(LinkedHashSet<IEnvironmentObject> EnvironmentObjects, IAgent<TPrecept, TAction> agent)
        {
            return base.ProcessSensors(EnvironmentObjects, agent);
        }
        #endregion


    }
}
