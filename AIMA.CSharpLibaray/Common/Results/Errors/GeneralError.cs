namespace AIMA.CSharpLibrary.Common.Results.Errors
{
    /// <summary>
    /// 26 June 2024
    /// </summary>
    public partial class GeneralError : BaseErrors
    {
        #region cstor
        /// <summary>
        /// 
        /// </summary>
        public GeneralError() : base()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ErrorMessage"></param>
        public GeneralError(string ErrorMessage) : base()
        {
            AddError(ErrorMessage);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="errorMessages"></param>
        /// <param name="globalErrorMessage"></param>
        public GeneralError(List<string> errorMessages, string globalErrorMessage = "General Error Or Undefined") : base(errorMessages, globalErrorMessage)
        {
        }
        #endregion

        #region Methods
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override string GetErrorType
        {
            get
            {
                return GetType().Name;
            }
        }
       
        #endregion

    }
}
