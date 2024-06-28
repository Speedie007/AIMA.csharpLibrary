using AIMA.CSharpLibrary.Common.Results.Errors;

namespace AIMA.CSharpLibrary.Common.Results
{
    /// <summary>
    /// 26 June 2024
    /// </summary>
    public interface  IResult
    {
        /// <summary>
        /// 
        /// </summary>
        bool Success { get; }
        /// <summary>
        /// 
        /// </summary>
        List<BaseErrors> Errors { get; }
        /// <summary>
        /// 
        /// </summary>
        void LogResults();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="error"></param>
        void SaveError(BaseErrors error);
    }
}
