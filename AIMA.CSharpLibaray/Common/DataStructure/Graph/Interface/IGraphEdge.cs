using AIMA.CSharpLibrary.Common.DataStructure.Graph.Base;

namespace AIMA.CSharpLibrary.Common.DataStructure.Graph.Interface
{
    /// <summary>
    /// 28 June
    /// </summary>
    /// <typeparam name="TVertex"></typeparam>
    public partial interface IGraphEdge<TVertex> where TVertex : BaseGraphNode, new()
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        TVertex GetVertex();
        /// <summary>
        /// Also Known as Adjacent NodeDataContext
        /// </summary>
        /// <returns>Parent/Adjacent NodeDataContext</returns>
        TVertex GetAdjacentVertex();
        /// <summary>
        /// 
        /// </summary>
        KeyValuePair<TVertex, TVertex> Edge { get; set; }




    }
}
