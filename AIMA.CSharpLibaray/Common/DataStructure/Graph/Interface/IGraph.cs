using AIMA.CSharpLibrary.Common.DataStructure.Graph.Base;
using AIMA.CSharpLibrary.Common.Results;

namespace AIMA.CSharpLibrary.Common.DataStructure.Graph.Interface
{
    /// <summary>
    /// 28 June
    /// </summary>
    /// <typeparam name="TVertex"></typeparam>
    /// <typeparam name="TEdge"></typeparam>
    public partial interface IGraph<TVertex, TEdge>
        where TVertex : BaseGraphNode, new()
        where TEdge : BaseGraphEdge<TVertex>, new()
    {


        #region Properties
        /// <summary>
        /// An adjacency list represents a graph as an array of linked lists.
        /// The KEY Of type TNODE => 
        /// </summary>
        SortedList<TVertex, LinkedList<TEdge>> GraphAdjacencyList { get; }
        /// <summary>
        /// 
        /// </summary>
        bool IsDirectedGraph { get; }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexNode"></param>
        /// <param name="adjacentNode"></param>
        /// <returns></returns>
        bool ContainsEdge(TVertex vertexNode, TEdge adjacentNode);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexNode"></param>
        /// <returns></returns>
        bool HasEdges(TVertex vertexNode);
        //BaseGraphEdge<TNodeContext,TVertex> forwardEdge, BaseGraphEdge<TNodeContext, TVertex> reverseEdge
        //bool TryAddEdge(BaseGraphEdge<TNodeContext, TVertex> forwardEdge, BaseGraphEdge<TNodeContext, TVertex> reverseEdge);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="forwardEdge"></param>
        /// <param name="reverseEdge"></param>
        /// <returns></returns>
        bool TryAddEdge(TEdge forwardEdge, TEdge reverseEdge);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexNode"></param>
        /// <returns></returns>
        bool TryRemoveVertex(TVertex vertexNode);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexNode"></param>
        /// <param name="adjacentNode"></param>
        /// <returns></returns>
        TEdge? GetEdge(TVertex vertexNode, TVertex adjacentNode);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexNode"></param>
        /// <returns></returns>
        LinkedList<TEdge> GetEdges(TVertex vertexNode);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexNode"></param>
        /// <param name="edge"></param>
        /// <returns></returns>
        bool TryRemoveEdge(TVertex vertexNode, TEdge edge);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexNode"></param>
        /// <returns></returns>
        bool TryAddVertex(TVertex vertexNode);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexNode"></param>
        /// <returns></returns>
        bool HasVertex(TVertex vertexNode);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nodeId"></param>
        /// <returns></returns>
        TVertex GetVertex(int nodeId);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<TVertex> GetAllLeafNodes();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="edge"></param>
        /// <returns></returns>
        double GetEdgeWeight(TEdge edge);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="edge"></param>
        /// <param name="edgeWeight"></param>
        /// <returns></returns>
        bool SetEdgeWeight(TEdge edge, double edgeWeight = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool IsTree();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool HasStartingNode();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool HasEndNode();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int AmountOfEdges();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="edge"></param>
        /// <returns></returns>
        IResult TryAddEdge(TEdge edge);
        //IResult TryAddEdge(TVertex forwardVertex, TVertex adjacentVertex);
        #endregion
    }
}
