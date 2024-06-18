using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions
{
    /// <summary>
    /// <para>Vacuum Cleaner Move action, which defines the basic methods for the resulting Move Up action that can be made by the vacuum cleaner.</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. IT) - Complied C# Implementation
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
    }

    

    

   
   
}
