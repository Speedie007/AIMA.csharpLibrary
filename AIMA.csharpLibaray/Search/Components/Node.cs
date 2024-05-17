namespace AIMA.csharpLibrary.Search.Components
{
    /// <summary>
    /// <para>Artificial Intelligence A Modern Approach (3rd Edition): Figure 3.10, page 79.</para>
    /// <para>
    /// Figure 3.10 Nodes are the data structures from which the search tree is constructed. Each has a parent, a state, and various bookkeeping fields. Arrows point from child to parent.
    /// </para>
    /// <para>
    /// Search algorithms require a data structure to keep track of the search tree that is being constructed. For each node n of the tree, we have a structure that contains four components:
    /// </para>
    /// <code>n.NodeState: The state in the state space to which the node corresponds;</code>
    /// <code>n.ParentNode: the node in the search tree that generated this node;</code>
    /// <code>n.ActionApplied: the action that was applied to the parent to generate the node;</code>
    /// <code>n.PathCost: the cost, traditionally denoted by g(n), of the path from the initial state to the node, as indicated by the parent pointers.</code>
    ///<para>
    ///Author:Ciaran O'Reilly
    ///</para>
    ///<para>
    ///Author:Mike Stampone
    ///</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 17 May 2024 - Date Last Updated: 17 May 2024</para>
    /// </summary>
    /// <typeparam name="TState">The type used to represent states</typeparam>
    /// <typeparam name="TAction">The type of the actions to be used to navigate through the state space</typeparam>
    /// <param name="nodeState">The state in the state space to which the node corresponds.</param>
    /// <param name="parentNode">The node in the search tree that generated the node.</param>
    /// <param name="actionApplied">The action that was applied to the parent to generate the node.</param>
    /// <param name="pathCost"></param>
    public partial class Node<TState, TAction>(
        TState nodeState,
        Node<TState, TAction> parentNode,
        TAction actionApplied,
        double pathCost)
    {
        #region properties
        /// <summary>
        /// n.NodeState: the state in the state space to which the node corresponds;
        /// </summary>
        public TState NodeState { get; private set; } = nodeState;
        /// <summary>
        /// n.ParentNode: the node in the search tree that generated this node;
        /// </summary>
        public Node<TState, TAction> ParentNode { get; private set; } = parentNode;
        /// <summary>
        /// n.ActionApplied: the action that was applied to the parent to generate the node;
        /// </summary>
        public TAction ActionApplied { get; private set; } = actionApplied;
        /// <summary>
        /// n.PathCost: the cost, traditionally denoted by g(n), of the path from the initial state to the node, as indicated by the parent pointers.
        /// </summary>
        public double PathCost { get; private set; } = pathCost;
        /// <summary>
        /// n.Depth: the depth of the node in the search space.
        /// </summary>
        public int Depth { get; private set; } = parentNode != null ? parentNode.Depth + 1 : 0;

        public bool IsRootNode { get { return ParentNode == null; } }

        #endregion
        #region Methods
        public override string? ToString()
        {
            return "[parent=" + ParentNode.GetType().Name + ", action=" + ActionApplied?.ToString() + ", state=" + NodeState?.ToString() + ", pathCost=" + PathCost + "]";
        }

        #endregion
    }
}
