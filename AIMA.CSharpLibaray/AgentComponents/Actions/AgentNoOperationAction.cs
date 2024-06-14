using AIMA.CSharpLibrary.AgentComponents.Agent;

namespace AIMA.CSharpLibrary.AgentComponents.Actions
{
    /// <summary>
    /// <para>Base(Abstract) Enviroment used to represent the domain within wich the agent operates.</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 23 May 2024 - Date Last Updated: 17 May 2024</para>
    /// </summary>
    public partial class AgentNoOperationAction : BaseAgentAction
    {
        private const string actionName = "NoOperation";
        #region Ctsor
        public AgentNoOperationAction() : base(nameof(AgentNoOperationAction))
        {

        }
        #endregion
        public override Type DynamicAtrributeType()
        {
            return GetType();
        }

    }
}
