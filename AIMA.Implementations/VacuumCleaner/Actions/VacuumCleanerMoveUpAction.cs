using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Interface;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions
{
    /// <summary>
    /// <para>Vacuum Cleaner Move action, which defines the basic methods for the resulting Move Up action that can be made by the vacuum cleaner.</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation
    ///</para>
    ///<para>Date Created: 23 May 2024 - Date Last Updated: 16 June 2024</para>
    /// </summary>
    public class VacuumCleanerMoveUpAction : BaseVacuumCleanerMovementAction
    {
        /// <summary>
        /// 
        /// </summary>
        public VacuumCleanerMoveUpAction() : base(nameof(VacuumCleanerMoveUpAction))
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
        /// <param name="currentLocation"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override XYLocation GetNextLocation(XYLocation currentLocation)
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
