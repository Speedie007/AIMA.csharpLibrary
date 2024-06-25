using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Interface;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions.Interfaces;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions
{
    /// <summary>
    /// 9 June
    /// </summary>
    public partial class VacuumCleanerAction : BaseAction, IVacuumCleanerAction 
    {
        /// <summary>
        /// 
        /// </summary>
        public VacuumCleanerAction() : base()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public VacuumCleanerAction(string name) : base(name)
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
