using AIMA.CSharpLibrary.AgentComponents.Actions;

namespace AIMA.CSharpLibrary.AgentComponents.Agent.Extentsions
{
    public static class ActionExtentions
    {
        public static BaseAgentAction GetNoOperationAction()
        {

            var noOperationAction = new AgentNoOperationAction();

            return noOperationAction;

        }
    }
}
