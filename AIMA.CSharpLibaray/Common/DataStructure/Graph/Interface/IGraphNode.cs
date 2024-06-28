namespace AIMA.CSharpLibrary.Common.DataStructure.Graph.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public partial interface IGraphNode//<TNodeContext> 
         : INode//<TNodeContext>
                //where TNodeContext : NodeBaseContextEntity
    {
        /// <summary>
        /// 
        /// </summary>
        int Level { get; }
        /// <summary>
        /// 
        /// </summary>
        bool IsVisited { get; }
        /// <summary>
        /// 
        /// </summary>
        bool IsStartNode { get; }
        /// <summary>
        /// 
        /// </summary>
        bool IsEndNode { get; }
        /// <summary>
        /// 
        /// </summary>
        void IncrementLevel();
        /// <summary>
        /// 
        /// </summary>
        void MarkNodeAsVisited();
        /// <summary>
        /// 
        /// </summary>
        void SetAsStartingNode();
        /// <summary>
        /// 
        /// </summary>
        void SetAsEndNode();
        /// <summary>
        /// 
        /// </summary>
        void RemoveAsStartingNode();
        /// <summary>
        /// 
        /// </summary>
        void RemoveAsEndNode();

        /// <summary>
        /// 
        /// </summary>
        int GetNodeIdentifier();
        /// <summary>
        /// 
        /// </summary>
        void ResetLevel();
        /// <summary>
        /// 
        /// </summary>
        void ResetVisited();



    }
}
