using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions.Interfaces;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions
{
    /// <summary>
    /// 9 June
    /// </summary>
    public partial class VacuumCleanerAction : AbstractAction, IVacuumCleanerAction
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


    }
}
