using AIMA.csharpLibrary.AgentComponents.Agent.Interface;
using AIMA.csharpLibrary.AgentComponents.Common;

namespace AIMA.csharpLibrary.AgentComponents.Agent
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
    public partial class AgentAction : ComponentDynamicAttributes, IAgentAction
    {
        public static string ATTRIBUTE_NAME = "name";
        #region Ctsor
        public AgentAction(string name)
        {
            SetDynamicAttributeValue(ATTRIBUTE_NAME, name);
        }
        #endregion

        public string? getName()
        {
            return (string?)GetDynamicAttributeValue(ATTRIBUTE_NAME);
        }
        public override string DynamicAtrributeType()
        {
            return GetType().Name;
        }

    }
}
