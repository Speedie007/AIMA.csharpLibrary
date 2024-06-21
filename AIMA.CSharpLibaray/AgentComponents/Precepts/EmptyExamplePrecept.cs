using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Precepts
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    ///  <remarks>
    ///  This implementation serves as default Example precept which observes SomeOrOtherPrecept.
    /// </remarks>
    public partial class EmptyExamplePrecept : BasePrecept
    {
        #region Cstor
        /// <summary>
        /// Initializes and empty precept which observes SomeOrOtherPrecept.
        /// </summary>
        public EmptyExamplePrecept() : base()
        {
        }
        #endregion


        #region Properties
        /// <value>
        /// 
        /// </value>
        public string SomeOrOtherPrecept
        {
            get
            {
                return (string)GetAttributeValue(nameof(SomeOrOtherPrecept));
            }
            set
            {
                SetDynamicAttributeValue(nameof(SomeOrOtherPrecept), value);
            }
        }
        #endregion

    }
}
