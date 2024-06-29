using AIMA.CSharpLibrary.Common.DataStructure.Graph.Base;

namespace AIMA.CSharpLibrary.Common.DataStructure.Graph
{
    /// <summary>
    /// 28 June
    /// </summary>
    /// <typeparam name="TVertex"></typeparam>
    public partial class GraphEdge<TVertex> : BaseGraphEdge<TVertex>
         where TVertex : BaseGraphNode,new()
    {
        /// <summary>
        /// 
        /// </summary>
        public GraphEdge() : base() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexNode"></param>
        /// <param name="adjacentNode"></param>
        public GraphEdge(TVertex vertexNode, TVertex adjacentNode) : base(vertexNode, adjacentNode)
        {
        }
    }
}
