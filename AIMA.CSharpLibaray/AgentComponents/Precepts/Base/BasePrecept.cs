using AIMA.CSharpLibrary.AgentComponents.Common;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Interface;

namespace AIMA.CSharpLibrary.AgentComponents.Precepts.Base
{
    /// <summary>
    /// <para>
    /// Artificial Intelligence A Modern Approach (3rd Edition): pg 34.
    /// </para>
    /// <list type="bullet">
    ///  <item>
    /// <description>
    /// Figure 2.1 Agents interact with environments through sensors and actuators.
    /// </description>
    /// </item>
    /// <item>
    /// <description>
    /// We use the term percept to refer the agent's perceptual inputs at any give instant.
    /// </description>
    /// </item>
    ///</list>
    ///<list type="bullet">
    ///<item>
    ///<description>Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental</description>
    ///</item>
    ///</list>
    /// <para>Date Created: 10 May 2024 - Date Last Updated: 19 June 2024</para>
    /// </summary>
    public abstract class BasePrecept : BaseDynamicProperties, IAgentPrecept
    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public BasePrecept() : base()
        {

        }
        #endregion
    }
}

