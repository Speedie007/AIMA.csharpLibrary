using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.Common;

namespace AIMA.CSharpLibrary.AgentComponents.Agent
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
    ///Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 13 May 2024 - Date Last Updated: 17 May 2024</para>
    /// </summary>
    public abstract partial class BaseAgentAction : ComponentDynamicAttributes, IAgentAction
    {
        private static readonly string ATTRIBUTE_NAME = "name";

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public string ActionName
        {
            get
            {
                return (string)GetAttributeValue(ATTRIBUTE_NAME);
            }
        }
        #endregion
        #region Ctsor
        public BaseAgentAction(string name)
        {
            SetDynamicAttributeValue(ATTRIBUTE_NAME, name);
        }
        #endregion


        public abstract override Type DynamicAtrributeType();
        

    }
}
