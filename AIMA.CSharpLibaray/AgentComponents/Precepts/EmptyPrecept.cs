using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Precepts
{
    /// <summary>
    /// <para>
    /// Artificial Intelligence A Modern Approach (3rd Edition): Figure 2.1, page 35.
    /// </para>
    /// <para>Figure 2.1 Agents interact with environments through sensors and actuators.</para>
    /// <para>Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental</para>
    /// <para>Date Created: 10 May 2024 - Date Last Updated: 11 May 2024</para>
    /// </summary>
    public partial class EmptyPrecept : BasePrecept
    {
        /// <summary>
        /// Initializes and empty precept which observes nothing.
        /// </summary>
        public EmptyPrecept() : base()
        {
        }
    }
}
