using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.State;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public static class NodeExtensions<TState, TAction>
        where TState : BaseAgentState, new()    
        where TAction : BaseAction
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static List<TAction> ToActions(Node<TState, TAction>? node)
        {
            return node != null ? getSequenceOfActions(node) : new List<TAction>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static TState ToState(Node<TState, TAction> node)
        {
            return node != null ? node.NodeState : new();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
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
