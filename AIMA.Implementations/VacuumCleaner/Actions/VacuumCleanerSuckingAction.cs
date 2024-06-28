using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.PerformanceMeasure;
using AIMA.CSharpLibrary.Common.DataStructure;
using AIMA.Implementations.VacuumCleaner.Agents;
using AIMA.Implementations.VacuumCleaner.Infrastructure.Extensions;
using AIMA.Implementations.VacuumCleaner.PerformanceMeasure;

namespace AIMA.Implementations.VacuumCleaner.Actions
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

        /// <param name="environmentObjects"><inheritdoc/></param>
        /// <param name="agent"><inheritdoc/></param>
        public override void ExecuteAction<TPrecept, TAction>(LinkedDictonarySet<IEnvironmentObject> environmentObjects, BaseAgent<TPrecept, TAction> agent)
        {
            var agentLocationResult = environmentObjects.GetAgentLocationState(agent);
            if (agentLocationResult.Success)
            {
                if (agent is ReflexVacuumCleanerAgent)
                {
                    if (agentLocationResult.MazeBlockState is not null)
                    {
                        agentLocationResult.MazeBlockState.DirtPiles.Pop();
                        if (agent.PerformanceMeasure is not null)
                        {
                          
                            agent.PerformanceMeasure.EvaluatePerformanceMeasureByActionTaken(this);
                            agent.OnAgentPerformanceMeasureUpdated(
                                new AgentPerformanceMeasureUpdatedEventArgs<TPrecept, TAction>(
                                    agent,
                                    agent.PerformanceMeasure));
                        }
                    }
                }
            }
        }
    }
}
