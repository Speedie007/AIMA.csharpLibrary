using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Sensors.Base;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Infrastucture.EnviromentObjects;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Sensors.Interface;
using AIMA.CSharpLibrary.Common.DataStructure;
using System.Reflection;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Sensors
{
    public partial class VacuumCleanerLocationSensor : BaseSensor<VacuumCleanerPrecept,VacuumCleanerAction>, IVacuumCleanerSensor
    {

        #region cstor
        public VacuumCleanerLocationSensor()
        {
            
        }

        public override VacuumCleanerPrecept Poll(VacuumCleanerPrecept precept, LinkedHashSet<IEnvironmentObject> EnvironmentObjects, IAgent<VacuumCleanerPrecept,VacuumCleanerAction> agent)
        {
            foreach (IEnvironmentObject environmentObject in EnvironmentObjects.Where(x => x.GetType() == typeof(MazeBlock<VacuumCleanerPrecept, VacuumCleanerAction>)))
            {
                
                PropertyInfo[] propInfos = environmentObject.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

                PropertyInfo? agentProperty = propInfos.FirstOrDefault(x => x.Name == nameof(MazeBlock<VacuumCleanerPrecept, VacuumCleanerAction>.Agent));
                var agentInLocation = agentProperty?.GetValue(environmentObject) as IAgent<VacuumCleanerPrecept, VacuumCleanerAction>;
                if (agentInLocation is not null) {
                    PropertyInfo? blockLocation = propInfos.FirstOrDefault(x => x.Name == nameof(MazeBlock<VacuumCleanerPrecept, VacuumCleanerAction>.GridLocation));
                    precept.AgentCurrentLocation = blockLocation?.GetValue(environmentObject) is XYLocation loc ? loc : new XYLocation(1, 1);
                }
            }

            return precept;
        }
        #endregion


    }
}
