using AIMA.CSharpLibrary.AgentComponents.State.Base;

namespace AIMA.CSharpLibrary.AgentComponents.State
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ExampleState : BaseState
    {

        #region cstor
        /// <summary>
        /// 
        /// </summary>
        public ExampleState() : base()
        {

        }
        #endregion

        #region Preoperties
        /// <summary>
        /// /
        /// </summary>
        public string SomeOrOtherStateProperty
        {
            get
            {
                return (string)GetAttributeValue(nameof(SomeOrOtherStateProperty));
            }
            set { SetDynamicAttributeValue(nameof(SomeOrOtherStateProperty), value); }
        }
        #endregion
    }
}
