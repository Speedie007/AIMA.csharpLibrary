using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.Common.DataStructure;
using AIMA.Implementations.VacuumCleaner.Actions.Interfaces;

namespace AIMA.Implementations.VacuumCleaner.Actions
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
        
        /// <param name="environmentObjects"><inheritdoc/></param>
        /// <param name="agent"><inheritdoc/></param>
        public override void ExecuteAction<TPrecept, TAction>(LinkedDictonarySet<IEnvironmentObject> environmentObjects, BaseAgent<TPrecept, TAction> agent)
        {

        }
    }
}
