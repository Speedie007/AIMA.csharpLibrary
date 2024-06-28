using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base.Implementations;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.Common.DataStructure;
using AIMA.Implementations.VacuumCleaner.Actions;
using AIMA.Implementations.VacuumCleaner.Models;
using AIMA.Implementations.VacuumCleaner.PerformanceMeasure;
using AIMA.Implementations.VacuumCleaner.Precept;
using AIMA.Implementations.VacuumCleaner.State;

namespace AIMA.Implementations.VacuumCleaner.VacuumCleanerPrograms
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ModelBasedVacuumCleanerReflexAgentProgram : BaseModelBasedReflexAgentProgram< VacuumCleanerPrecept, VacuumCleanerAction, VacuumCleanerState, VacuumCleanerModel>
    {
        /// <summary>
        /// 
        /// </summary>
        public ModelBasedVacuumCleanerReflexAgentProgram()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void InitializeAgentProgramComponents()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="environmentObjects"></param>
        /// <param name="action"></param>
        /// <param name="agent"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void ProcessAgentAction(
            LinkedDictionarySet<IEnvironmentObject> environmentObjects,
            VacuumCleanerAction action,
            BaseAgent< VacuumCleanerPrecept, VacuumCleanerAction> agent)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        /// <param name="action"></param>
        /// <param name="percept"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        protected override VacuumCleanerState UpdateState(
            VacuumCleanerState state,
            VacuumCleanerAction action,
            VacuumCleanerPrecept percept,
            VacuumCleanerModel model)
        {
            throw new NotImplementedException();
        }
    }
}
