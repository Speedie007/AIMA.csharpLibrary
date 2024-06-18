using AIMA.CSharpLibrary.AgentComponents.Common;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Interface;

namespace AIMA.CSharpLibrary.AgentComponents.Precepts.Base
{
    /// <summary>
    /// <para>
    /// Artificial Intelligence A Modern Approach (3rd Edition): pg 34.
    /// </para>
    /// <para>
    /// We use the term percept to refer the agent's perceptual inputs at any give instant.
    ///</para>
    /// <remarks>
    ///  This implementation serves as default precept which observes Nothing.
    /// </remarks>
    /// </summary>
    public abstract class BasePrecept : ComponentDynamicAttributes, IAgentPrecept
    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public BasePrecept():base()
        {

        }
        #endregion
    }
}
