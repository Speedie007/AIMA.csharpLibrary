using AIMA.CSharpLibrary.AgentComponents.Actions.Interface;
using AIMA.CSharpLibrary.AgentComponents.Common;

namespace AIMA.CSharpLibrary.AgentComponents.Actions.Base
{
    /// <summary>
    /// <para>Base(Abstract) Enviroment used to represent the domain within wich the agent operates.</para>
    ///<para>
    ///Author:Ciaran O'Reilly
    ///</para>
    ///<para>
    ///Author:Mike Stampone
    ///</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 13 May 2024 - Date Last Updated: 16 June 2024</para>
    /// </summary>
    public abstract partial class AbstractAction : AbstractDynamicProperties, IAgentAction
    {
        #region Properties
        /// <summary>
        /// Read-Only Property => Return the User Friendly Name of the Agent ActionExecuted
        /// </summary>
        public string ActionName
        {
            get
            {
                return (string)GetAttributeValue(AgentComponentDefaults.ACTION_NAME);
            }
        }
        #endregion
        #region Ctsor
        /// <summary>
        /// Assigned the default user friendly name for the agent action.
        /// </summary>
        /// <param name="name">String Value => Assgined the System Class Name as the user friendly name of the Agents ActionExecuted</param>
        public AbstractAction(string name)
        {
            SetDynamicAttributeValue(AgentComponentDefaults.ACTION_NAME, name);
        }
        /// <summary>
        /// Creates a default acition which is to do Nothing
        /// </summary>
        public AbstractAction() : this(AgentComponentDefaults.ACTION_NO_OPERATION)
        {

        }
        #endregion
    }
}
