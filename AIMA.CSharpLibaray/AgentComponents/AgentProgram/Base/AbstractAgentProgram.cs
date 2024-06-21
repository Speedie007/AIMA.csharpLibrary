using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Interface;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.AgentComponents.Sensors.Base;
using AIMA.CSharpLibrary.AgentComponents.Sensors.Interface;
using AIMA.CSharpLibrary.Common.DataStructure;
using System.Reflection;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram
{
    /// <summary>
    /// <para>
    /// Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 23 May 2024 - Date Last Updated: 17 June 2024</para>
    /// </summary>
    /// <typeparam name="TPrecept">Base Agent Precept Type</typeparam>
    /// <typeparam name="TAction">Base Agent Action Type</typeparam>
    public abstract partial class AbstractAgentProgram<TPrecept, TAction> : IAgentProgram<TPrecept, TAction>
        where TAction : AbstractAction, new()
        where TPrecept : BasePrecept, new()
    {
        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public Func<TPrecept, AbstractAction> AgentFunction { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public Func<LinkedHashSet<IEnvironmentObject>, IAgent<TPrecept, TAction>, TPrecept> SensorPollingFunc { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<Type, IAgentSensor<TPrecept, TAction>> Sensors { get; private set; }
        #endregion

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        protected AbstractAgentProgram()
        {
            AgentFunction = ProcessAgentFunction;
            SensorPollingFunc = ProcessSensors;
            Sensors = new Dictionary<Type, IAgentSensor<TPrecept, TAction>>();
            InitializeSensors();
        }
        #endregion

        #region Methods
        /// <summary>
        /// <para>Function Maps Precept to a possible action.</para>
        /// </summary>
        /// <param name="percept">The Current Precept genrated by the agent sensors based on the current enviroment CurrentState.</param>
        /// <returns>Action, which the agent must perform.</returns>
        public abstract TAction ProcessAgentFunction(TPrecept percept);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="EnvironmentObjects"></param>
        /// <param name="agent"></param>
        /// <returns></returns>
        protected virtual TPrecept ProcessSensors(LinkedHashSet<IEnvironmentObject> EnvironmentObjects, IAgent<TPrecept, TAction> agent)
        {
            var precept = new TPrecept();
            foreach (var sensor in Sensors.Values)
            {
                precept = sensor.Poll(precept, EnvironmentObjects, agent);
            }
            return precept;
        }

        /// <summary>
        /// Intitalized method used for possible customized or additional initialization of the agent Program components in the derived Agent Program.
        /// </summary>
        public abstract void Initialize();

        /// <summary>
        /// Detects all the releveant sensors been defined for the agent.
        /// <para>The sensors are initialized and stored in the local cache.</para>
        /// <para>The Sensors required are determined by the combination of the assigned Precept and Actions assigned to the agent.</para>
        /// </summary>
        private void InitializeSensors()
        {
            Type parentType = typeof(BaseSensor<TPrecept, TAction>);
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();

            IEnumerable<Type> subclasses = types.Where(t => t.IsSubclassOf(parentType) && !t.IsAbstract);
            foreach (Type sensorType in subclasses)
            {
                var sensor = Activator.CreateInstance(sensorType) as IAgentSensor<TPrecept, TAction>;
                if (sensor is not null)
                    Sensors.TryAdd(sensorType, sensor);
            }
        }
        #endregion




    }
}
