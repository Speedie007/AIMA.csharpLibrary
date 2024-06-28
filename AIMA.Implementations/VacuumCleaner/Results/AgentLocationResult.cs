using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.Results;
using AIMA.Implementations.VacuumCleaner.Environment.EnvironmentObjects;

namespace AIMA.Implementations.VacuumCleaner.Results
{
    /// <summary>
    /// 26 June 2024
    /// </summary>
    public partial class AgentLocationResult<TPerformanceMeasure, TPrecept, TAction> : GeneralResult
        where TPrecept : BasePrecept, new()
        where TAction : BaseAction, new()
        where TPerformanceMeasure: BasePerformanceMeasure, new()
    {
        /// <summary>
        /// 
        /// </summary>
        public MazeBlock<TPerformanceMeasure, TPrecept, TAction>? MazeBlockState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public AgentLocationResult()
        //{
        //    LocationDirtPiles = new List<Dirt>();
        //}
        ///// <summary>
        ///// 
        ///// </summary>
        //public XYLocation? AgentLocation { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public List<Dirt> LocationDirtPiles { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public override bool Success
        {
            get
            {
                if (MazeBlockState == null)
                {
                    if (!Errors.Any(x => x.GetErrorType == typeof(AgentLocationStateNotFoundError).Name))
                    { Errors.Add(new AgentLocationStateNotFoundError()); }
                    return false;
                }
                else
                {
                    var agentLocationErrors = Errors.Where(x => x.GetType() == typeof(AgentLocationStateNotFoundError)).ToList();
                    foreach (var agentLocationError in agentLocationErrors)
                    { Errors.Remove(agentLocationError); }
                    return base.Success;
                }
            }
        }
    }
}
