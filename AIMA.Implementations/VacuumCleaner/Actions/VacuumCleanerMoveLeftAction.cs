using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Interface;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions
{
    /// <summary>
    /// 
    /// </summary>
    public class VacuumCleanerMoveLeftAction : BaseVacuumCleanerMovementAction
    {
        /// <summary>
        /// 
        /// </summary>
        public VacuumCleanerMoveLeftAction() : base(nameof(VacuumCleanerMoveLeftAction))
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FromLocation"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override XYLocation GetNextLocation(XYLocation FromLocation)
        {
            throw new NotImplementedException();
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
            base.ExecuteAction(enviromentObjects, agent);
        }
    }
}
