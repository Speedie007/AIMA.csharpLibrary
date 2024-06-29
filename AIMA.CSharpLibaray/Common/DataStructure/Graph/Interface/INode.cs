using AIMA.CSharpLibrary.Common.DataStructure.Graph.Base;

namespace AIMA.CSharpLibrary.Common.DataStructure.Graph.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public partial interface INode : IComparable<INode>
    //where TNodeContext : NodeBaseContextEntity
    {
        /// <summary>
        /// 
        /// </summary>
        //Guid NodeID { get; } 
        /// <summary>
        /// 
        /// </summary>
        NodeBaseContextEntity NodeDataContext { get; }

        //event NodeVisitedEventHandler<TNodeContext> OnNodeVisited;
        //event LastNodeVisitedEventHandler<TNodeContext> OnLastNodeVisited;
        //event FirstNodeVisitedEventHandler<TNodeContext> OnFirstNodeVisited;
        //event NodeLevelEventHandler<TNodeContext> OnNodeLevelChanged;
    }
}
