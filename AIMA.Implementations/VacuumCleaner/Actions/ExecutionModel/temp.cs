﻿using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.Common.DataStructure;
using AIMA.Implementations.VacuumCleaner.Agents;
using AIMA.Implementations.VacuumCleaner.Precept;

namespace AIMA.Implementations.VacuumCleaner.Actions.ExecutionModel
{
    /// <summary>
    /// 
    /// </summary>
    internal class Temp : BaseActionExecutionModel<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="environmentObjects"></param>
        public Temp(ReflexVacuumCleanerAgent agent, LinkedDictionarySet<IEnvironmentObject> environmentObjects) : base(agent, environmentObjects)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void ExecuteAction()
        {
            throw new NotImplementedException();
        }
    }
}
