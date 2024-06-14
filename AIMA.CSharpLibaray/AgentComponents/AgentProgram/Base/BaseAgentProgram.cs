using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Interface;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts;
using AIMA.CSharpLibrary.AgentComponents.Sensors.Base;
using AIMA.CSharpLibrary.AgentComponents.Sensors.Interface;
using AIMA.CSharpLibrary.Common.DataStructure;
using System.Reflection;
using System.Runtime.Remoting;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram
{
    /// <summary>
    /// <para>
    /// Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 23 May 2024 - Date Last Updated: 23 May 2024</para>
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public abstract partial class BaseAgentProgram<TAgent, TPrecept, TAction> : IAgentProgram<TAgent, TPrecept, TAction>
        where TAction : BaseAgentAction, new()
        where TPrecept : BaseAgentPrecept, new()
       where TAgent : IAgent<TPrecept, TAction>
    {
        public Func<TPrecept, TAction> PreceptToActionFunc { get; private set; }
        public Func<LinkedHashSet<IEnvironmentObject>, TAgent, TPrecept> SensorPollingFunc { get; private set; }

        public Dictionary<Type, IAgentSensor<TPrecept, TAction>> Sensors { get; private set; }


        protected BaseAgentProgram()
        {
            PreceptToActionFunc = ProcessAgentPecept;
            SensorPollingFunc = ProcessSensors;
            Sensors = new Dictionary<Type, IAgentSensor<TPrecept, TAction>>();
            InitializeSensors();
        }

        /// <summary>
        /// <para>Function TABLE-DRIVEN-AGENT(percept) returns an action</para>
        /// </summary>
        /// <param name="percept"></param>
        /// <returns></returns>
        public abstract TAction ProcessAgentPecept(TPrecept percept);
        public virtual TPrecept ProcessSensors(LinkedHashSet<IEnvironmentObject> EnvironmentObjects, TAgent agent)
        {
            var precept = new TPrecept();
            foreach (var sensor in Sensors.Values)
            {
                precept = sensor.Poll(precept, EnvironmentObjects, agent);
            }
            return precept;
        }

        public abstract void Initialize();

        public void InitializeSensors()
        {
            Type parentType = typeof(BaseSensor<TPrecept, TAction>);
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();

            IEnumerable<Type> subclasses = types.Where(t => t.IsSubclassOf(parentType) && !t.IsAbstract);
            foreach (var sensorType in subclasses)
            {
                var sensor = Activator.CreateInstance(sensorType) as IAgentSensor<TPrecept, TAction>;
                Sensors.TryAdd(sensorType, sensor);
            }
        }

    }
}
