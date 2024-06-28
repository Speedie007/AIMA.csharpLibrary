using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.PerformanceMeasure;
using AIMA.CSharpLibrary.Common.DataStructure;
using AIMA.Implementations.VacuumCleaner.Actions.Base;
using AIMA.Implementations.VacuumCleaner.Agents;
using AIMA.Implementations.VacuumCleaner.Environment.EnvironmentObjects;
using AIMA.Implementations.VacuumCleaner.Infrastructure.Extensions;

namespace AIMA.Implementations.VacuumCleaner.Actions
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
            return new XYLocation(FromLocation.CurrentXCoOrdinate - 1, FromLocation.CurrentYCoOrdinate);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="TPrecept"><inheritdoc/></typeparam>
        /// <typeparam name="TAction"><inheritdoc/></typeparam>
        
        /// <param name="environmentObjects"><inheritdoc/></param>
        /// <param name="agent"><inheritdoc/></param>
        public override void ExecuteAction<TPrecept, TAction>(LinkedDictonarySet<IEnvironmentObject> environmentObjects, BaseAgent< TPrecept, TAction> agent)
        {
            var agentLocationResult = environmentObjects.GetAgentLocationState(agent);
            if (agentLocationResult.Success)
            {
                if (agent is ReflexVacuumCleanerAgent)
                {
                    if (agentLocationResult.MazeBlockState is not null)
                    {
                        var locationAgentMovingTo = environmentObjects.OfType<MazeBlock<TPrecept, TAction>>()
                                .FirstOrDefault(x => x.GridLocation.Equals(GetNextLocation(agentLocationResult.MazeBlockState.GridLocation)));

                        agentLocationResult.MazeBlockState.Agent = null;
                        if (locationAgentMovingTo is not null)
                            locationAgentMovingTo.Agent = agent;

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
