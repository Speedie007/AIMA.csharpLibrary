using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base.Implementations;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Interface;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Enviroment.EnviromentObjects;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept;
using AIMA.CSharpLibrary.Common.DataStructure;
using System.Reflection;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.VacumCleanerPrograms
{
    /// <summary>
    /// <para>Artificial Intelligence A Modern Approach (3rd Edition): pg 58.</para>
    /// 
    /// </summary>
    public partial class ReflexVacuumCleanerAgentProgram : BaseReflexAgentProgram<VacuumCleanerPrecept, VacuumCleanerAction>

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


        #endregion

        #region Methods
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override void InitializeAgentProgramComponents()
        {

        }

        public override void ProcessAgentAction(LinkedDictonarySet<IEnviromentObject> enviromentObjects, VacuumCleanerAction action, BaseAgent<VacuumCleanerPrecept, VacuumCleanerAction> agent)
        {
            //TODO: build Result object to return the success or failure of this operation.


            PropertyInfo[] propInfos = enviromentObjects.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            PropertyInfo? agentProperty = propInfos.FirstOrDefault(x => x.Name == nameof(MazeBlock<VacuumCleanerPrecept, VacuumCleanerAction>.Agent));
            var agentInLocation = agentProperty?.GetValue(enviromentObjects) as IAgent<VacuumCleanerPrecept, VacuumCleanerAction>;
            if (agentInLocation is not null)
            {
                PropertyInfo? blockLocation = propInfos.FirstOrDefault(x => x.Name == nameof(MazeBlock<VacuumCleanerPrecept, VacuumCleanerAction>.GridLocation));
                var agentLocation = blockLocation?.GetValue(enviromentObjects) as XYLocation;

                if (agentLocation is not null)
                {
                    action.ExecuteAction(enviromentObjects, agent);
                }
            }
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
