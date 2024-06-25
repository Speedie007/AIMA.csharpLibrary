using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Interface;
using AIMA.CSharpLibrary.AgentComponents.Sensor.Base;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Enviroment.EnviromentObjects;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Sensors.Interface;
using AIMA.CSharpLibrary.Common.DataStructure;
using System.Reflection;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Sensors
{
    /// <summary>
    /// 
    /// </summary>
    public partial class VacuumCleanerLocationSensor : BaseSensor<VacuumCleanerPrecept, VacuumCleanerAction>, IVacuumCleanerSensor
    {

        #region cstor
        /// <summary>
        /// 
        /// </summary>
        public VacuumCleanerLocationSensor()
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
        public override VacuumCleanerPrecept Poll(VacuumCleanerPrecept precept, LinkedDictonarySet<IEnviromentObject> EnvironmentObjects, IAgent<VacuumCleanerPrecept, VacuumCleanerAction> agent)
        {
            foreach (IEnviromentObject environmentObject in EnvironmentObjects.Where(x => x.GetType() == typeof(MazeBlock<VacuumCleanerPrecept, VacuumCleanerAction>)))
            {

                PropertyInfo[] propInfos = environmentObject.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

                PropertyInfo? agentProperty = propInfos.FirstOrDefault(x => x.Name == nameof(MazeBlock<VacuumCleanerPrecept, VacuumCleanerAction>.Agent));
                var agentInLocation = agentProperty?.GetValue(environmentObject) as IAgent<VacuumCleanerPrecept, VacuumCleanerAction>;
                if (agentInLocation is not null)
                {
                    PropertyInfo? blockLocation = propInfos.FirstOrDefault(x => x.Name == nameof(MazeBlock<VacuumCleanerPrecept, VacuumCleanerAction>.GridLocation));
                    precept.AgentCurrentLocation = blockLocation?.GetValue(environmentObject) is XYLocation loc ? loc : new XYLocation(1, 1);
                }
            }

            return precept;

        }

    }
    #endregion
}
