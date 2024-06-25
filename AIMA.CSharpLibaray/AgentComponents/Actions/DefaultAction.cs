using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Interface;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Actions
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DefaultAction : BaseAction
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public DefaultAction() : base()
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="name"><inheritdoc/></param>
        public DefaultAction(string name) : base(name)
        {
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="TPrecept"><inheritdoc/></typeparam>
        /// <typeparam name="TAction"><inheritdoc/></typeparam>
        /// <param name="enviromentObjects"><inheritdoc/></param>
        /// <param name="agent"><inheritdoc/></param>
        public override void ExecuteAction<TPrecept, TAction>(LinkedDictonarySet<IEnviromentObject> enviromentObjects, BaseAgent<TPrecept, TAction> agent)
        {
        }
    }
}
