using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.AgentComponents.Sensor.Base;
using AIMA.CSharpLibrary.Common.DataStructure;
using AIMA.Implementations.VacuumCleaner.Actions;
using AIMA.Implementations.VacuumCleaner.Environment.EnvironmentObjects;
using AIMA.Implementations.VacuumCleaner.PerformanceMeasure;
using AIMA.Implementations.VacuumCleaner.Precept;
using AIMA.Implementations.VacuumCleaner.Sensors.Interface;

namespace AIMA.Implementations.VacuumCleaner.Sensors
{
    /// <summary>
    /// 9 June 2024
    /// </summary>
    public partial class VacuumCleanerDirtSensor : BaseSensor< VacuumCleanerPrecept, VacuumCleanerAction>, IVacuumCleanerSensor
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public VacuumCleanerDirtSensor()
        {
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override void InitialiseSensor()
        {

        }

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
            IAgent< VacuumCleanerPrecept, VacuumCleanerAction> agent)
        {
            foreach (var enviroLoc in EnvironmentObjects.OfType<MazeBlock< VacuumCleanerPrecept, VacuumCleanerAction>>())
            {
                if (enviroLoc.Agent is not null && enviroLoc.Agent.Equals(agent))
                {
                    precept.CurrentLocationHasDirt = enviroLoc.IsDirty;
                }
            }

            return precept;
        }
    }
}
//foreach (IEnvironmentObject environmentObject in EnvironmentObjects.Where(x => x.GetType() == typeof(MazeBlock<VacuumCleanerPrecept, VacuumCleanerAction>)))
//{

//    PropertyInfo[] propInfo = environmentObject.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

//    PropertyInfo? agentProperty = propInfo.FirstOrDefault(x => x.Name == nameof(MazeBlock<VacuumCleanerPrecept, VacuumCleanerAction>.Agent));
//    var agentAtLocation = agentProperty?.GetValue(environmentObject) as IAgent<VacuumCleanerPrecept, VacuumCleanerAction>;
//    if (agentAtLocation is not null)
//    {
//        PropertyInfo? blockLocation = propInfo.FirstOrDefault(x => x.Name == nameof(MazeBlock<VacuumCleanerPrecept, VacuumCleanerAction>.IsDirty));
//        precept.CurrentLocationHasDirt = blockLocation?.GetValue(environmentObject) is bool locationDirt ? locationDirt : false;
//    }
//}