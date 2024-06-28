using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures;
using AIMA.CSharpLibrary.AgentComponents.Sensor.Base;
using AIMA.CSharpLibrary.Common.DataStructure;
using AIMA.Implementations.VacuumCleaner.Actions;
using AIMA.Implementations.VacuumCleaner.Infrastructure.Extensions;
using AIMA.Implementations.VacuumCleaner.PerformanceMeasure;
using AIMA.Implementations.VacuumCleaner.Precept;
using AIMA.Implementations.VacuumCleaner.Sensors.Interface;

namespace AIMA.Implementations.VacuumCleaner.Sensors
{
    /// <summary>
    /// 
    /// </summary>
    public partial class VacuumCleanerLocationSensor : BaseSensor<VacuumCleanerPerformanceMeasure, VacuumCleanerPrecept, VacuumCleanerAction>, IVacuumCleanerSensor
    {

        #region cstor
        /// <summary>
        /// 
        /// </summary>
        public VacuumCleanerLocationSensor()
        {

        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override void InitialiseSensor()
        {
            
        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="precept"></param>
        /// <param name="EnvironmentObjects"></param>
        /// <param name="agent"></param>
        /// <returns></returns>
        public override VacuumCleanerPrecept Poll(
            VacuumCleanerPrecept precept,
            LinkedDictonarySet<IEnvironmentObject> EnvironmentObjects,
            IAgent<VacuumCleanerPerformanceMeasure, VacuumCleanerPrecept, VacuumCleanerAction> agent)
        {
            var agentLocationResult = EnvironmentObjects.GetAgentLocationState(agent);
            if (agentLocationResult.Success)
            {
                if (agentLocationResult.MazeBlockState is not null)
                    precept.AgentCurrentLocation = agentLocationResult.MazeBlockState.GridLocation;
            }

            return precept;

        }

    }
    #endregion
}


//foreach (IEnvironmentObject environmentObject in EnvironmentObjects.Where(x => x.GetType() == typeof(MazeBlock<VacuumCleanerPrecept, VacuumCleanerAction>)))
//{

//    PropertyInfo[] propInfo = environmentObject.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

//    PropertyInfo? agentProperty = propInfo.FirstOrDefault(x => x.Name == nameof(MazeBlock<VacuumCleanerPrecept, VacuumCleanerAction>.Agent));
//    var agentInLocation = agentProperty?.GetValue(environmentObject) as IAgent<VacuumCleanerPrecept, VacuumCleanerAction>;
//    if (agentInLocation is not null)
//    {
//        PropertyInfo? blockLocation = propInfo.FirstOrDefault(x => x.Name == nameof(MazeBlock<VacuumCleanerPrecept, VacuumCleanerAction>.GridLocation));
//        precept.AgentCurrentLocation = blockLocation?.GetValue(environmentObject) is XYLocation loc ? loc : new XYLocation(1, 1);
//    }
//}