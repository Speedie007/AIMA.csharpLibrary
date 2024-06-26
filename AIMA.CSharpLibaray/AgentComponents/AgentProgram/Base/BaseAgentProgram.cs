﻿using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Interface;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.AgentComponents.Sensor.Base;
using AIMA.CSharpLibrary.AgentComponents.Sensor.Interface;
using AIMA.CSharpLibrary.Common.DataStructure;
using System.Reflection;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base
{
    /// <summary>
    /// <para>
    /// Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 23 May 2024 - Date Last Updated: 25 June 2024</para>
    /// </summary>
    /// <typeparam name="TPrecept">Base Agent Precept Type</typeparam>
    /// <typeparam name="TAction">Base Agent Action Type</typeparam>

    public abstract partial class BaseAgentProgram<TPrecept, TAction> : IAgentProgram<TPrecept, TAction>
        where TAction : BaseAction, new()
        where TPrecept : BasePrecept, new()
           
    {
        #region Properties
        /// <summary>
        /// <typeparamref name="TPrecept" />
        /// </summary>
        /// <value>
        /// Func<![CDATA[<TPrecept, BaseAction>]]>
        /// <typeparamref name="TPrecept" />
        /// <typeparamref name="TAction"/>
        /// </value>
        public Func<TPrecept, BaseAction> AgentPreceptToActionFunction { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public Func<LinkedDictionarySet<IEnvironmentObject>, IAgent<TPrecept, TAction>, TPrecept> SensorPollingFunction { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public Action<LinkedDictionarySet<IEnvironmentObject>, TAction, BaseAgent<TPrecept, TAction>> ProcessAgentActionFunction { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<Type, ISensor< TPrecept, TAction>> Sensors { get; private set; }
        #endregion

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        protected BaseAgentProgram()
        {
            SensorPollingFunction = ProcessSensors;
            AgentPreceptToActionFunction = ProcessAgentFunctionAsync;
            ProcessAgentActionFunction = ProcessAgentAction;
            Sensors = new Dictionary<Type, ISensor< TPrecept, TAction>>();
            InitializeSensors();
        }
        #endregion

        #region Methods
        /// <summary>
        /// <para>Function Maps Precept to a possible action.</para>
        /// </summary>
        /// <param name="percept">The Current Precept generated by the agent sensors based on the current environment CurrentState.</param>
        /// <returns>Action, which the agent must perform.</returns>
        public abstract TAction ProcessAgentFunctionAsync(TPrecept percept);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="environmentObjects"></param>
        /// <param name="action"></param>
        /// <param name="agent"></param>
        public abstract void ProcessAgentAction(LinkedDictionarySet<IEnvironmentObject> environmentObjects, TAction action, BaseAgent< TPrecept, TAction> agent);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="EnvironmentObjects"></param>
        /// <param name="agent"></param>
        /// <returns></returns>
        protected virtual TPrecept ProcessSensors(LinkedDictionarySet<IEnvironmentObject> EnvironmentObjects, IAgent< TPrecept, TAction> agent)
        {
            var precept = new TPrecept();
            foreach (var sensor in Sensors.Values)
            {
                precept = sensor.Poll(precept, EnvironmentObjects, agent);
            }
            return precept;
        }

        /// <summary>
        /// Initialized method used for possible customized or additional initialization of the agent Program components in the derived Agent Program.
        /// </summary>
        public abstract void InitializeAgentProgramComponents();

        /// <summary>
        /// <para>Detects all the relevant sensors been defined for the agent.</para>
        /// <list type="bullet">
        /// <item>
        /// <description>The sensors are initialized and stored in the local cache.</description>
        /// </item>
        /// <item>
        /// <description>The Sensors required are determined by the combination of the assigned Precept and Actions assigned to the agent.</description>
        /// </item>
        /// </list>
        /// </summary>
        private void InitializeSensors()
        {
            //Type parentType = typeof(BaseSensor<TPrecept, TAction>);
            //Assembly implementationAssembly = Assembly.Load("AIMA.Implementations");
            //Type[] implementationTypes = implementationAssembly.GetTypes();
            //IEnumerable<Type> subclasses = implementationTypes.Where(t => t.IsSubclassOf(parentType) && !t.IsAbstract);

            //foreach (Type sensorType in subclasses)
            //{
            //    var sensor = Activator.CreateInstance(sensorType) as ISensor<TPrecept, TAction>;
            //    if (sensor is not null)
            //        Sensors.TryAdd(sensorType, sensor);
            //}


            var entryAssembly = Assembly.GetEntryAssembly();
            var referencedAssemblies = entryAssembly?.GetReferencedAssemblies();
            if (referencedAssemblies is not null)
            {
                List<Type> assemblyTypes = new List<Type>();
                foreach (var ra in referencedAssemblies)
                {
                    var assemblyName = ra?.Name is string s ? s : "";
                    if (assemblyName.Length > 0)
                    {
                        var loadedReferenceAssembly = Assembly.Load(assemblyName);
                        assemblyTypes.AddRange(loadedReferenceAssembly.GetTypes());
                    }
                }
                IEnumerable<Type> subclasses = assemblyTypes.Where(t => t.IsSubclassOf(typeof(BaseSensor<TPrecept, TAction>)) && !t.IsAbstract);

                foreach (Type sensorType in subclasses)
                {
                    var sensor = Activator.CreateInstance(sensorType) as ISensor< TPrecept, TAction>;
                    if (sensor is not null)
                        Sensors.TryAdd(sensorType, sensor);
                }
            }


        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstArray"></param>
        /// <param name="secondArray"></param>
        /// <returns></returns>
        public Type[] MergeUsingArrayCopyWithNewArray(Type[] firstArray, Type[] secondArray)
        {
            var combinedArray = new Type[firstArray.Length + secondArray.Length];
            Array.Copy(firstArray, combinedArray, firstArray.Length);
            Array.Copy(secondArray, 0, combinedArray, firstArray.Length, secondArray.Length);
            return combinedArray;
        }


    }
}
