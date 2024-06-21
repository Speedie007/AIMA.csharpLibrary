using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base.Implementations;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.VacumCleanerPrograms
{
    /// <summary>
    /// <para>Artificial Intelligence A Modern Approach (3rd Edition): pg 58.</para>
    /// 
    /// </summary>
    public partial class ReflexVacuumCleanerAgentProgram : AbstractReflexAgentProgram<VacuumCleanerPrecept, VacuumCleanerAction>

    {

        private readonly XYLocation Location_A = new XYLocation(1, 1);
        private readonly XYLocation Location_B = new XYLocation(2, 1);
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public ReflexVacuumCleanerAgentProgram() : base()
        {

        }
        /// <inheritdoc/>
        public override VacuumCleanerAction ProcessAgentFunction(VacuumCleanerPrecept percept)
        {

            //Set thew action to Default => NoOperation ActionExecuted.
            VacuumCleanerAction action = new();
            if (percept.CurrentLocationHasDirt)
            {
                action = new VacuumCleanerSuckAction();
            }
            else if (percept.AgentCurrentLocation.Equals(Location_A))
            {
                action = new VacuumCleanerMoveRightAction();
            }
            else if (percept.AgentCurrentLocation.Equals(Location_B))
            {
                action = new VacuumCleanerMoveLeftAction();
            }
       
            return action;
        }
        #endregion
    }
}
