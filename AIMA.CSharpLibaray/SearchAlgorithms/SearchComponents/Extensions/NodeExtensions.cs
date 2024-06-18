using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.State;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public static class NodeExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static List<TAction> GetSequenceOfActions<TState, TAction>(this Node<TState, TAction> node)
            where TState : BaseAgentState, new()
            where TAction : BaseAction, new()
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
        public static List<TAction> ToActions<TState, TAction>(this Node<TState, TAction>? node)
            where TState : BaseAgentState, new()
            where TAction : BaseAction, new()
        {
            return node != null ? GetSequenceOfActions(node) : new List<TAction>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static TState ToState<TState, TAction>(this Node<TState, TAction> node)
            where TState : BaseAgentState, new()
            where TAction : BaseAction, new()
        {
            return node != null ? node.NodeState : new();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static List<Node<TState, TAction>> GetPathFromRoot<TState, TAction>(this Node<TState, TAction> node)
            where TState : BaseAgentState, new()
            where TAction : BaseAction, new()
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
