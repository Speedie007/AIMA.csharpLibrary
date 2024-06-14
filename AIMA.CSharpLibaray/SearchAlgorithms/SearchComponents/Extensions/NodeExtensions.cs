using AIMA.CSharpLibrary.AgentComponents.Agent;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Extensions
{
    public static class NodeExtensions<TState, TAction>
        where TState : BaseAgentState ,new()
        where TAction : BaseAgentAction
    {
        public static List<TAction> getSequenceOfActions(Node<TState, TAction> node)
        {
            LinkedList<TAction> actions = new LinkedList<TAction>();
            while (!node.IsRootNode)
            {
                actions.AddFirst(node.ActionApplied!);
                node = node.ParentNode!;
            }
            return actions.ToList();
        }
        public static List<TAction> ToActions(Node<TState, TAction>? node)
        {
            return node != null ? getSequenceOfActions(node) : new List<TAction>();
        }
        public static TState ToState(Node<TState, TAction> node)
        {
            return node != null ? node.NodeState : new();
        }
        public static List<Node<TState, TAction>> GetPathFromRoot(Node<TState, TAction> node)
        {
            LinkedList<Node<TState, TAction>> path = new LinkedList<Node<TState, TAction>>();

            while (!node.IsRootNode)
            {
                path.AddFirst(node);
                node = node.ParentNode!;
            }
            path.AddFirst(node);

            return path.ToList();
        }
    }
}
