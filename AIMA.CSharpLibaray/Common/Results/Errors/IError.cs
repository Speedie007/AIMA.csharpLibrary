namespace AIMA.CSharpLibrary.Common.Results.Errors
{
    /// <summary>
    /// 26 June 2024
    /// </summary>
    public partial interface IError
    {
        /// <summary>
        /// 
        /// </summary>
        List<string> AllErrorMessages { get; }
        /// <summary>
        /// 
        /// </summary>
        string GetErrorType { get; }
        /// <summary>
        /// 
        /// </summary>
        string GlobalErrorMessage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="errorMessage"></param>
        void AddError(string errorMessage);
    }
}
