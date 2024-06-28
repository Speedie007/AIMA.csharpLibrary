using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;
using AIMA.Implementations.VacuumCleaner.Environment.EnvironmentObjects;
using AIMA.Implementations.VacuumCleaner.Results;
using System.Reflection;

namespace AIMA.Implementations.VacuumCleaner.Infrastructure.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class VacuumCleanerEnvironmentStateExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TPrecept"></typeparam>
        /// <typeparam name="TAction"></typeparam>
        
        /// <param name="environmentObjects"></param>
        /// <param name="agent"></param>
        /// <returns></returns>
        public static AgentLocationResult< TPrecept, TAction> GetAgentLocationState<TPrecept, TAction>(
            this LinkedDictionarySet<IEnvironmentObject> environmentObjects,
            IAgent<TPrecept, TAction> agent) 
            where TPrecept : BasePrecept, new() 
            where TAction : BaseAction, new()
              
        {
            AgentLocationResult<TPrecept, TAction> result = new();

            foreach (var enviroLoc in environmentObjects.Where(x => x.GetType() == typeof(MazeBlock< TPrecept, TAction>)).ToList())
            {
                var loc = enviroLoc as MazeBlock< TPrecept, TAction>;
                if (loc is not null)
                    if (loc.LocationHasAgent && agent.Equals(loc.Agent))
                        result.MazeBlockState = loc;
            }
            return result;
        }
    }
}


//foreach (IEnvironmentObject enviroLoc in environmentObjects.Where(x => x.GetType() == typeof(MazeBlock<TPrecept, TAction>)))
//{

//    PropertyInfo[] mazeBlockPropInfo = enviroLoc.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

//    PropertyInfo? agentProperty = mazeBlockPropInfo.FirstOrDefault(x => x.Name == nameof(MazeBlock<TPrecept, TAction>.Agent));
//    var agentInLocation = agentProperty?.GetValue(enviroLoc) as IAgent<TPrecept, TAction>;
//   //if the agent found then logically the this is its current location
//    if (agentInLocation is not null && agent.Equals(agentInLocation))
//    {

//        PropertyInfo? blockLocation = mazeBlockPropInfo.FirstOrDefault(x => x.Name == nameof(MazeBlock<TPrecept, TAction>.GridLocation));
//        result.AgentLocation = blockLocation?.GetValue(enviroLoc) is XYLocation loc ? loc : null;
//    }
//}