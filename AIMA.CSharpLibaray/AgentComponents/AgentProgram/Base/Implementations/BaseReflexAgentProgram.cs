using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base.Implementations
{
    /// <summary>
    /// 16 June
    /// </summary>
    /// <typeparam name="TPrecept"><inheritdoc/></typeparam>
    /// <typeparam name="TAction"><inheritdoc/></typeparam>
    /// <typeparam name="TPerformanceMeasure"><inheritdoc/></typeparam>
    public abstract partial class BaseReflexAgentProgram<TPerformanceMeasure,TPrecept, TAction> : 
        BaseAgentProgram<TPerformanceMeasure, TPrecept, TAction>
        where TAction : BaseAction, new()
        where TPrecept : BasePrecept, new()
        where TPerformanceMeasure: BasePerformanceMeasure, new()
    {



        #region Cstr
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        protected BaseReflexAgentProgram() : base()
        {
        }
        
        #endregion



    }
}
