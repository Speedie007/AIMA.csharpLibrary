using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Interface;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions
{
    /// <summary>
    /// <para>Vacuum Cleaner Suck action, which defines the basic methods for the resulting sucking action that can be made by the vacuum cleaner.</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation
    ///</para>
    ///<para>Date Created: 23 May 2024 - Date Last Updated: 16 June 2024</para>
    /// </summary>
    public class VacuumCleanerSuckAction : VacuumCleanerAction
    {
        /// <summary>
        /// Vacuum Cleaner Suck Constructor
        /// </summary>
        public VacuumCleanerSuckAction() : base(nameof(VacuumCleanerSuckAction))
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
            base.ExecuteAction(enviromentObjects, agent);
        }
    }
}
