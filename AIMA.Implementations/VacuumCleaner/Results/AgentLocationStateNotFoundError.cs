using AIMA.CSharpLibrary.Common.Results.Errors;

namespace AIMA.Implementations.VacuumCleaner.Results
{
    /// <summary>
    /// 26 June 2024
    /// </summary>
    public partial class AgentLocationStateNotFoundError : BaseErrors
    {
        /// <summary>
        /// 
        /// </summary>
        public AgentLocationStateNotFoundError():base(
            new List<string>(), "Agent Location Not Found")
        { }
    }
}
