using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base.Implementations;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.Common.DataStructure;
using AIMA.Implementations.VacuumCleaner.Actions;
using AIMA.Implementations.VacuumCleaner.PerformanceMeasure;
using AIMA.Implementations.VacuumCleaner.Precept;

namespace AIMA.Implementations.VacuumCleaner.VacuumCleanerPrograms
{
    /// <summary>
    /// <para>Artificial Intelligence A Modern Approach (3rd Edition): pg 58.</para>
    /// 
    /// </summary>
    public partial class ReflexVacuumCleanerAgentProgram : BaseReflexAgentProgram< VacuumCleanerPrecept, VacuumCleanerAction>

    {

        private readonly XYLocation Location_A = new(1, 1);
        private readonly XYLocation Location_B = new(2, 1);
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public ReflexVacuumCleanerAgentProgram() : base()
        {

        }


        #endregion

        #region Methods
        /// <summary>
        /// <inheritdoc/>
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
        public override void ProcessAgentAction(
            LinkedDictonarySet<IEnvironmentObject> environmentObjects,
            VacuumCleanerAction action,
            BaseAgent< VacuumCleanerPrecept, VacuumCleanerAction> agent)
        {

            action.ExecuteAction(environmentObjects, agent);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="percept"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public override VacuumCleanerAction ProcessAgentFunctionAsync(VacuumCleanerPrecept percept)
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
