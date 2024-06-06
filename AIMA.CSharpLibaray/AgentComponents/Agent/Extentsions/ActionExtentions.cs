using NUnit.Framework;

namespace AIMA.CSharpLibrary.AgentComponents.Agent.Extentsions
{
    public static class ActionExtentions
    {
        public static BaseAgentAction GetNoOperationAction()
        {
           
           var noOperationAction = new AgentActionNoOperation();
           
            return noOperationAction;

        }
    }
}
