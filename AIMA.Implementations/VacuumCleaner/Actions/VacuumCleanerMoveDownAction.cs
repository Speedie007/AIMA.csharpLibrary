using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.Common.DataStructure;
using AIMA.Implementations.VacuumCleaner.Actions.Base;

namespace AIMA.Implementations.VacuumCleaner.Actions
{
    /// <summary>
    /// 9 June
    /// </summary>
    public class VacuumCleanerMoveDownAction : BaseVacuumCleanerMovementAction
    {
        /// <summary>
        /// 
        /// </summary>
        public VacuumCleanerMoveDownAction() : base(nameof(VacuumCleanerMoveDownAction))
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FromLocation"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override bool CanMoveToNextLocation(XYLocation FromLocation)
        {
            return false;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="FromLocation"></param>
        /// <returns></returns>
        public override XYLocation GetNextLocation(XYLocation FromLocation)
        {
            return new(1, 1);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="TPrecept"><inheritdoc/></typeparam>
        /// <typeparam name="TAction"><inheritdoc/></typeparam>
        /// <typeparam name="TPerformanceMeasure"></typeparam>
        /// <param name="environmentObjects"><inheritdoc/></param>
        /// <param name="agent"><inheritdoc/></param>
        public override void ExecuteAction<TPerformanceMeasure,TPrecept, TAction>(LinkedDictonarySet<IEnvironmentObject> environmentObjects, BaseAgent<TPerformanceMeasure, TPrecept, TAction> agent)
        {
            base.ExecuteAction(environmentObjects, agent);
        }
    }
}
