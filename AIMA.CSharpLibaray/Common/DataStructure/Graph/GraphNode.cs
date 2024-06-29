using AIMA.CSharpLibrary.Common.DataStructure.Graph.Base;

namespace AIMA.CSharpLibrary.Common.DataStructure.Graph
{
    /// <summary>
    /// 28 June
    /// </summary>
    public partial class GraphNode : BaseGraphNode
    {

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nodeContext"></param>
        /// <param name="isStartNode"></param>
        /// <param name="isEndNode"></param>
        public GraphNode(
            NodeBaseContextEntity nodeContext,
            bool isStartNode = false,
            bool isEndNode = false) : base(nodeContext, isStartNode, isEndNode)
        {
        }
    }
}
