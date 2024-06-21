using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.State;
using System.Diagnostics.CodeAnalysis;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents
{
    /// <summary>
    /// <para>Artificial Intelligence A Modern Approach (3rd Edition): Figure 3.10, page 79.</para>
    /// <para>
    /// Figure 3.10 Nodes are the data structures from which the search tree is constructed. Each has A parent, A state, and various bookkeeping fields. Arrows point from child to parent.
    /// </para>
    /// <para>
    /// Search algorithms require A data structure to keep track of the search tree that is being constructed. For each node n of the tree, we have A structure that contains four components:
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
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 17 May 2024 - Date Last Updated: 17 May 2024</para>
    /// </summary>
    /// <typeparam name="TState">The type used to represent states</typeparam>
    /// <typeparam name="TAction">The type of the actions to be used to navigate through the state space</typeparam>

    public partial class Node<TState, TAction> :
        IComparer<Node<TState, TAction>>, IEqualityComparer<Node<TState, TAction>>
            where TAction : AbstractAction, new()
            where TState : BaseState, new()
    {
        /// <summary>
        /// Constructs A node with the specified state, parent, action, and path cost.
        /// </summary>
        /// <param name="nodeState">The state in the state space to which the node corresponds.</param>
        /// <param name="parentNode">The node in the search tree that generated the node.</param>
        /// <param name="actionApplied">The action that was applied to the parent to generate the node.</param>
        /// <param name="pathCost">full pathCost from the root node to here, typically the root's path costs plus the step costs for executing the specified action.</param>
        public Node(TState nodeState, Node<TState, TAction>? parentNode, TAction? actionApplied, double pathCost)
        {
            NodeState = nodeState;
            ParentNode = parentNode;
            ActionApplied = actionApplied;
            PathCost = pathCost;
            Depth = parentNode != null ? parentNode.Depth + 1 : 0;
        }

        /// <summary>
        /// Constructs A root node for the specified state.
        /// </summary>
        /// <param name="state">The state in the state space to which the node corresponds.</param>
        public Node(TState state) : this(state, null, null, 0.0)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        public Node() : this(new TState())
        {

        }

        #region properties
        /// <summary>
        /// 
        /// </summary>
        public Guid ID { get; private set; } = Guid.NewGuid();
        /// <summary>
        /// n.NodeState: the state in the state space to which the node corresponds;
        /// </summary>
        public TState NodeState { get; private set; }// = nodeState;
        /// <summary>
        /// n.ParentNode: the node in the search tree that generated this node;
        /// </summary>
        public Node<TState, TAction>? ParentNode { get; private set; }// = parentNode;
        /// <summary>
        /// n.ActionApplied: the action that was applied to the parent to generate the node;
        /// </summary>
        public TAction? ActionApplied { get; private set; }// = actionApplied;
        /// <summary>
        /// n.PathCost: the cost, traditionally denoted by g(n), of the path from the initial state to the node, as indicated by the parent pointers.
        /// </summary>
        public double PathCost { get; private set; }// = pathCost;
        /// <summary>
        /// n.Depth: the depth of the node in the search space.
        /// </summary>
        public int Depth { get; private set; }// = parentNode != null ? parentNode.Depth + 1 : 0;
        /// <summary>
        /// 
        /// </summary>
        public bool IsRootNode { get { return ParentNode == null; } }


        #endregion
        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(Node<TState, TAction>? x, Node<TState, TAction>? y)
        {
            if (x == null || y == null)
                return 0;

            if (x.PathCost.CompareTo(y.PathCost!) != 0)
            {
                return x.PathCost.CompareTo(y.PathCost);
            }
            //else if (x.Depth.CompareTo(y.Depth) != 0)
            //{
            //    return x.Depth.CompareTo(y.Depth);
            //}
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "[parent=" + ParentNode!.GetType().Name + ", action=" + ActionApplied?.ToString() + ", state=" + NodeState?.ToString() + ", pathCost=" + PathCost + "]";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool Equals(Node<TState, TAction>? x, Node<TState, TAction>? y)
        {
            if (ReferenceEquals(x, y))
                return true;

            if (x is null || y is null)
                return false;

            if (!x.GetType().Equals(y.GetType()))
                return false;

            return x.ID.Equals(y.ID);
            //&& x.PathCost == y.PathCost
            //&& ReferenceEquals(x.ParentNode, y.ParentNode)
            //&& x.NodeState.ToString().Equals(y.NodeState.ToString())
            //&& x.Depth == y.Depth
            //&& x.ActionApplied.ActionName().Equals(y.ActionApplied.ActionName());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int GetHashCode([DisallowNull] Node<TState, TAction> node)
        {
            return node.ID.GetHashCode(); //node.IsRootNode.GetHashCode() ^ node.PathCost.GetHashCode() ^ node.NodeState.GetHashCode() ^ node.Depth ^;
        }

        #endregion
    }
}
