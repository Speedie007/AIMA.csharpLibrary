using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.Implementations.VacuumCleaner.Actions.Interfaces
{
    /// <summary>
    /// <para>Vacuum Cleaner movemt action Interface, which defines the basic methods for the resulting movements that can be made by the vacuum cleaner.</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 23 May 2024 - Date Last Updated: 23 May 2024</para>
    /// </summary>
    public interface IVacuumCleanerMovementAction : IVacuumCleanerAction
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FromLocation"></param>
        /// <returns></returns>
        bool CanMoveToNextLocation(XYLocation FromLocation);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FromLocation"></param>
        /// <returns>XYLocation, the XYLocation reference the x and y coordinates of the next location.</returns>
        XYLocation GetNextLocation(XYLocation FromLocation);
    }
}
