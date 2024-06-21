using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Sensors.Base;
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
    public partial class VacuumCleanerDirtSensor : BaseSensor<VacuumCleanerPrecept, VacuumCleanerAction>, IVacuumCleanerSensor
    {
        /// <summary>
        /// 
        /// </summary>
        public VacuumCleanerDirtSensor()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="precept"></param>
        /// <param name="EnvironmentObjects"></param>
        /// <param name="agent"></param>
        /// <returns></returns>
        public override VacuumCleanerPrecept Poll(VacuumCleanerPrecept precept, LinkedHashSet<IEnvironmentObject> EnvironmentObjects, IAgent<VacuumCleanerPrecept, VacuumCleanerAction> agent)
        {
            foreach (IEnvironmentObject environmentObject in EnvironmentObjects.Where(x => x.GetType() == typeof(MazeBlock<VacuumCleanerPrecept, VacuumCleanerAction>)))
            {

                PropertyInfo[] propInfos = environmentObject.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

                PropertyInfo? agentProperty = propInfos.FirstOrDefault(x => x.Name == nameof(MazeBlock<VacuumCleanerPrecept, VacuumCleanerAction>.Agent));
                var agentAtLocation = agentProperty?.GetValue(environmentObject) as IAgent<VacuumCleanerPrecept, VacuumCleanerAction>;
                if (agentAtLocation is not null)
                {
                    PropertyInfo? blockLocation = propInfos.FirstOrDefault(x => x.Name == nameof(MazeBlock<VacuumCleanerPrecept, VacuumCleanerAction>.IsDirty));
                    precept.CurrentLocationHasDirt = blockLocation?.GetValue(environmentObject) is bool locationDirt ? locationDirt : false;
                }
            }

            return precept;
        }
    }
}
