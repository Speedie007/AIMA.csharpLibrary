namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ANDCondition : Condition
    {
        #region Properties
        /// <value> LeftCondition </value>
        public Condition LeftCondition { get; private set; }
        /// <value><c>RightCondition</c></value>
        public Condition RightCondition { get; private set; }
        #endregion
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="leftCondition"></param>
        /// <param name="rightConditoin"></param>
        public ANDCondition(Condition leftCondition, Condition rightConditoin)
        {
            LeftCondition = leftCondition;
            RightCondition = rightConditoin;
        }
        #endregion
    }
}
