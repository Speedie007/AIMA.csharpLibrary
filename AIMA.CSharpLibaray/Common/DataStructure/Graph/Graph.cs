using AIMA.CSharpLibrary.Common.DataStructure.Graph.Base;

/***Generics
 * https://www.youtube.com/@WilliamFiset-videos
 * https://www.tutorialspoint.com/convert-directed-graph-into-a-tree
//https://www.w3computing.com/articles/csharp-generics-advanced-techniques-best-practices/#google_vignette
//https://www.fairushyn.tech/posts/csharp-learning-path/middle-specialist/generics
//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/where-generic-type-constraint
Generics End
**/

namespace AIMA.CSharpLibrary.Common.DataStructure.Graph
{
    /// <summary>
    /// 28 June
    /// </summary>
    /// <typeparam name="TVertex"></typeparam>
    /// <typeparam name="TEdge"></typeparam>
    public class Graph<TVertex, TEdge> : BaseGraph<TVertex, TEdge>
        where TVertex : BaseGraphNode, new()
        where TEdge : BaseGraphEdge<TVertex>, new()
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isDirectedGraph"></param>
        public Graph(bool isDirectedGraph = false) : base(isDirectedGraph)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexNodes"></param>
        /// <param name="isDirectedGraph"></param>
        public Graph(List<TVertex> vertexNodes, bool isDirectedGraph = false) : base(vertexNodes, isDirectedGraph)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="allVertexNodesWithEdges"></param>
        /// <param name="isDirectedGraph"></param>
        public Graph(List<KeyValuePair<TVertex, LinkedList<TEdge>>> allVertexNodesWithEdges, bool isDirectedGraph = false) : base(allVertexNodesWithEdges, isDirectedGraph)
        {
        }
    }
}
