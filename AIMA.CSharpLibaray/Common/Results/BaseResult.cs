using AIMA.CSharpLibrary.Common.Results.Errors;

namespace AIMA.CSharpLibrary.Common.Results
{
    /// <summary>
    /// 26 June 2024
    /// </summary>
    public abstract partial class BaseResult : IResult

    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public BaseResult()
        {
            Errors = new List<BaseErrors>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public virtual bool Success
        {
            get
            {
                return Errors.Count == 0;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual List<BaseErrors> Errors { get; private set; } = new List<BaseErrors>();
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        public virtual void LogResults()
        {
            if (Success)
            {
                Console.WriteLine($"NO - Errors Found: {GetType().Name} - YES");
                Console.WriteLine();
            }
            else
                foreach (var error in Errors)
                {
                    foreach (string errorMessage in error.AllErrorMessages)
                    {
                        Console.WriteLine($"Errors Found:Type-[{error.GetType().Name}]\nMessage:{errorMessage}");
                        Console.WriteLine();
                    }
                }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="error"></param>
        public void SaveError(BaseErrors error)
        {
            Errors.Add(error);
        }
        #endregion

    }
}
