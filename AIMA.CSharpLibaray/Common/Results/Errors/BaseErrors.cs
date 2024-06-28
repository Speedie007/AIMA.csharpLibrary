namespace AIMA.CSharpLibrary.Common.Results.Errors
{
    /// <summary>
    /// 26 June 2024
    /// </summary>
    public abstract class BaseErrors : IError
    {

        #region Global property Variables
        private string _GlobalErrorMessage = "";
        #endregion

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public BaseErrors() : this(new List<string>())
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="errorMessages"></param>
        /// <param name="globalErrorMessage"></param>
        public BaseErrors(List<string> errorMessages, string globalErrorMessage = "General Error Or Undefined")
        {
            AllErrorMessages = new List<string>(errorMessages);
            GlobalErrorMessage = globalErrorMessage;
        }
        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public virtual string GetErrorType
        {
            get
            {
                return GetType().Name;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public List<string> AllErrorMessages { get; private set; } = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        public string GlobalErrorMessage
        {
            get { return $"{GetErrorType} - {_GlobalErrorMessage}"; }
            set { _GlobalErrorMessage = $"{GetErrorType} - {value}"; }
        }

        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="errorMessage"></param>
        public void AddError(string errorMessage)
        {
            AllErrorMessages.Add(errorMessage);
        }
        #endregion

    }
}
