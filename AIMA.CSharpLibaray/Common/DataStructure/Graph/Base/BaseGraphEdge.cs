using AIMA.CSharpLibrary.Common.DataStructure.Graph.Interface;

namespace AIMA.CSharpLibrary.Common.DataStructure.Graph.Base
{
    /// <summary>
    /// 28 June
    /// </summary>
    /// <typeparam name="TVertex"></typeparam>
    public abstract partial class BaseGraphEdge<TVertex> : IGraphEdge<TVertex> 
        where TVertex : BaseGraphNode , new()
    {
        #region cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexNode">Parent Vertex(NodeDataContext)</param>
        /// <param name="adjacentNode">Child Vertex(NodeDataContext)</param>
        public BaseGraphEdge(TVertex vertexNode, TVertex adjacentNode)
        {
            Edge = new KeyValuePair<TVertex, TVertex>(key: vertexNode, value: adjacentNode);
        }
        /// <summary>
        /// 
        /// </summary>
        protected BaseGraphEdge()
        {
            Edge = new KeyValuePair<TVertex, TVertex>();
        }

        #endregion
        /// <summary>
        /// 
        /// </summary>
        public KeyValuePair<TVertex, TVertex> Edge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Integer value which is the Id value of the child(To) Vertex(NodeDataContext)</returns>
        public virtual TVertex GetAdjacentVertex()
        {
            return Edge.Value;
        }
        /// <summary>
        /// 
        /// </summary>
        ///  <returns>Integer value which is the Id value of the parent(From) Vertex(NodeDataContext)</returns>
        public virtual TVertex GetVertex()
        {
            return Edge.Key;
        }
    }
}
