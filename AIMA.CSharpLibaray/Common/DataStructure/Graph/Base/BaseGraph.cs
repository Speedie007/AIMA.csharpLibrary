using AIMA.CSharpLibrary.Common.DataStructure.Graph.Interface;
using AIMA.CSharpLibrary.Common.Results;
using AIMA.CSharpLibrary.Common.Results.Errors;

namespace AIMA.CSharpLibrary.Common.DataStructure.Graph.Base
{
    /// <summary>
    /// 28 June
    /// </summary>
    /// <typeparam name="TVertex"></typeparam>
    /// <typeparam name="TEdge"></typeparam>
    public abstract partial class BaseGraph<TVertex, TEdge> : IGraph<TVertex, TEdge>
      // where TNodeContext : NodeBaseContextEntity
      where TVertex : BaseGraphNode, new()  //<TNodeContext>
      where TEdge : BaseGraphEdge<TVertex>, new()
    {
        #region cstor
        /// <summary>
        /// SortedList<TVertex, LinkedList TEdge
        /// </summary>
        /// <param name="isDirectedGraph"></param>
        public BaseGraph(bool isDirectedGraph = false)
        {
            //Initialise the AdjacencyList to represent the graph
            GraphAdjacencyList = new SortedList<TVertex, LinkedList<TEdge>>();
            IsDirectedGraph = isDirectedGraph;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexNodes"></param>
        /// <param name="isDirectedGraph"></param>
        public BaseGraph(List<TVertex> vertexNodes, bool isDirectedGraph = false) : this(isDirectedGraph)
        {
            //Populate the Model with the vertices provided, will still need to add the relevant edges separately.
            foreach (var node in vertexNodes)
                if (node != null)
                    GraphAdjacencyList.TryAdd(node, new LinkedList<TEdge>());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="allVertexNodesWithEdges"></param>
        /// <param name="isDirectedGraph"></param>
        public BaseGraph(List<KeyValuePair<TVertex, LinkedList<TEdge>>> allVertexNodesWithEdges, bool isDirectedGraph = false) : this(isDirectedGraph)
        {
            //Populate the Model with the vertices provided, will still need to add the relevant edges separately.
            GraphAdjacencyList = new SortedList<TVertex, LinkedList<TEdge>>(allVertexNodesWithEdges.ToDictionary());

        }
        #endregion

        /// <summary>
        /// A collection of edges E, represented as ordered pairs of vertices (u,v)- ParentNode and ChildNode
        /// </summary>
        public SortedList<TVertex, LinkedList<TEdge>> GraphAdjacencyList { get; private set; } = new SortedList<TVertex, LinkedList<TEdge>>();
        /// <summary>
        /// 
        /// </summary>
        public bool IsDirectedGraph { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertex"></param>
        /// <returns></returns>
        public virtual bool TryAddVertex(TVertex vertex)
        {
            return GraphAdjacencyList.TryAdd(vertex, new LinkedList<TEdge>());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual List<TVertex> GetAllLeafNodes()
        {
            var leafNodes = new List<TVertex>();
            foreach (var node in GraphAdjacencyList.Where(x => x.Value.Count == 0))
                leafNodes.Add(node.Key);
            return leafNodes;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexNode"></param>
        /// <returns></returns>
        public bool HasEdges(TVertex vertexNode)
        {
            //LinkedList<TEdge> edgeList;
            if (GraphAdjacencyList.TryGetValue(vertexNode, out LinkedList<TEdge>? edgeList))
                return edgeList.Count > 0;
            return false;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="edge"></param>
        /// <returns></returns>
        public virtual IResult TryAddEdge(TEdge edge)
        {
            var result = new GeneralResult();

            var forwardVertex = edge.GetVertex();
            var adjacentVertex = edge.GetAdjacentVertex();

            if (forwardVertex == null)
                result.SaveError(new GeneralError($"Forward Vertex Null unable to add the Graph Edge for {GetType().Name}"));

            if (adjacentVertex == null)
                result.SaveError(new GeneralError($"Adjacent Vertex Null unable to add the Graph Edge for {GetType().Name}"));


            if (result.Success)
            {
                if (forwardVertex is not null && adjacentVertex is not null)
                {
                    TryAddVertex(forwardVertex);
                    if (GraphAdjacencyList.TryGetValue(forwardVertex, out var forwardVertexNodeAdjacencyList))
                    {
                        var forwardEdge = new TEdge
                        {
                            Edge = new KeyValuePair<TVertex, TVertex>(forwardVertex, adjacentVertex)
                        };

                        if (!ContainsEdge(forwardVertex, forwardEdge))
                            forwardVertexNodeAdjacencyList.AddLast(forwardEdge);
                    }
                    else
                        result.SaveError(new GeneralError($"Unable to locate edge list for {forwardVertex.GetType().Name}, Vertex Id:{forwardVertex.GetNodeIdentifier()}"));

                    if (!IsDirectedGraph && result.Success)
                    {
                        TryAddVertex(adjacentVertex);
                        if (GraphAdjacencyList.TryGetValue(adjacentVertex, out var reverseVertexNodeAdjacencyList))
                        {
                            var reverseEdge = new TEdge
                            {
                                Edge = new KeyValuePair<TVertex, TVertex>(adjacentVertex, forwardVertex)
                            };

                            if (!ContainsEdge(adjacentVertex, reverseEdge))
                                reverseVertexNodeAdjacencyList.AddLast(reverseEdge);
                        }
                        else
                            result.SaveError(new GeneralError($"Unable to locate edge list for {adjacentVertex.GetType().Name}, Vertex Id:{adjacentVertex.GetNodeIdentifier()}"));
                    }
                }


            }
            //result.SaveError(new GeneralError($"Simulation ERROR - unable to add the Graph Edge for {GetType().Name}[{typeof(TNodeContext).Name}-{typeof(TVertex).Name}-{typeof(TEdge).Name}]"));
            //if (!result.Success)
            //{
            //    result.LogResults();
            //}
            return result;
        }
        //public virtual bool TryAddEdge(BaseGraphEdge<TNodeContext,TVertex> forwardEdge, BaseGraphEdge<TNodeContext, TVertex> reverseEdge)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="forwardEdge"></param>
        /// <param name="reverseEdge"></param>
        /// <returns></returns>
        public virtual bool TryAddEdge(TEdge forwardEdge, TEdge reverseEdge)
        {
            //if (vertexNode == null)
            //    return false;// throw new ArgumentNullException(nameof(vertexNode), "The Vertex(Parent NodeDataContext) Can not be Null!.");
            //else
            //    TryAddVertex(vertexNode);
            if (forwardEdge == null)
                return false;// throw new ArgumentNullException(nameof(forwardEdge), $"The Edge {nameof(forwardEdge)}  for Vertex(Parent NodeDataContext) ID:{vertexNode.Id} Can not be Null!.");

            //Add Forward Edge to the node
            //Check if it not already added to the AdjacencyList
            TVertex forwardVertexNode = forwardEdge.GetVertex();
            //Ensure that the Node Exists in the Graph
            if (!HasVertex(forwardVertexNode))
                TryAddVertex(forwardVertexNode);

            if (GraphAdjacencyList.TryGetValue(forwardVertexNode, out var forwardVertexNodeAdjacencyList))
            {
                bool forwardEdgeAdded;
                //var forwardEdge = new KeyValuePair<TNodeContext, TNodeContext>(vertexNode, forwardEdgeNode);
                //Ensure the integrity of the data structure test to ensure that the forwardEdge vertex(ChildNode) is not already Added.
                if (!ContainsEdge(forwardVertexNode, forwardEdge))
                {
                    forwardVertexNodeAdjacencyList.AddLast(forwardEdge);
                    forwardEdgeAdded = true;
                }
                else//Already Exists
                    forwardEdgeAdded = true;
                if (!IsDirectedGraph)
                {

                }
                if (!IsDirectedGraph)
                {
                    bool reverseEdgeAdded;
                    var AdjacentVertex = reverseEdge.GetVertex();
                    if (!HasVertex(AdjacentVertex))
                        TryAddVertex(AdjacentVertex);

                    //if the adjacent node exists 
                    if (GraphAdjacencyList.TryGetValue(AdjacentVertex, out var reverseVertexNodeAdjacencyList))
                    {

                        //Ensure the integrity of the data structure test to ensure that the forwardEdge vertex(ChildNode) is not already Added.
                        if (!ContainsEdge(AdjacentVertex, reverseEdge))
                        {
                            reverseVertexNodeAdjacencyList.AddLast(reverseEdge);
                            reverseEdgeAdded = true;
                        }
                        else//Already Added/Exists for the adjacent Node edges.
                            reverseEdgeAdded = true;

                        return reverseEdgeAdded;
                    }
                }
                else
                {
                    return forwardEdgeAdded;
                }
            }

            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexNode"></param>
        /// <param name="adjacentNode"></param>
        /// <returns></returns>
        public virtual TEdge? GetEdge(TVertex vertexNode, TVertex adjacentNode)
        {
            if (GraphAdjacencyList.TryGetValue(vertexNode, out var vertexNodeAdjacencyList))
                return vertexNodeAdjacencyList.Where(x => x.GetAdjacentVertex().GetNodeIdentifier() == adjacentNode.GetNodeIdentifier()).FirstOrDefault();
            else
                return default;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexNode"></param>
        /// <param name="edge"></param>
        /// <returns></returns>
        public bool TryRemoveEdge(TVertex vertexNode, TEdge edge)
        {
            if (GraphAdjacencyList.TryGetValue(vertexNode, out var vertexNodeAdjacencyList))
                foreach (TEdge currentEdge in vertexNodeAdjacencyList)
                    if (currentEdge.GetAdjacentVertex().GetNodeIdentifier() == edge.GetAdjacentVertex().GetNodeIdentifier())
                        return vertexNodeAdjacencyList.Remove(currentEdge);

            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexNode"></param>
        /// <returns></returns>
        public bool HasVertex(TVertex vertexNode)
        {
            return GraphAdjacencyList.ContainsKey(vertexNode);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexNode"></param>
        /// <returns></returns>
        public LinkedList<TEdge> GetEdges(TVertex vertexNode)
        {
            if (GraphAdjacencyList.TryGetValue(vertexNode, out var vertexNodeAdjacencyList))
                return vertexNodeAdjacencyList;
            else
                return new LinkedList<TEdge>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nodeId"></param>
        /// <returns></returns>
        public TVertex GetVertex(int nodeId)
        {
            return GraphAdjacencyList.Keys.FirstOrDefault(x => x.GetNodeIdentifier() == nodeId) is TVertex a ? a : new();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexNode"></param>
        /// <param name="edge"></param>
        /// <returns></returns>
        public bool ContainsEdge(TVertex vertexNode, TEdge edge)
        {
            if (GraphAdjacencyList.TryGetValue(vertexNode, out var nodeAdjacencyList))
            {
                var adjacentNode = nodeAdjacencyList.Where(x => x.GetAdjacentVertex().GetNodeIdentifier() == edge.GetAdjacentVertex().GetNodeIdentifier()).FirstOrDefault();
                if (adjacentNode != null)
                    return true;

                return false;
            }
            else
                return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="edge"></param>
        /// <returns></returns>
        public virtual double GetEdgeWeight(TEdge edge)
        {
            return 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="edge"></param>
        /// <param name="edgeWeight"></param>
        /// <returns></returns>
        public virtual bool SetEdgeWeight(TEdge edge, double edgeWeight = 0)
        {
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsTree()
        {
            var amountOfNodes = GraphAdjacencyList.Keys.Count;

            if (amountOfNodes == 0)
            {
                return false;
            }
            else
            {
                var amountOfEdges = 0;
                foreach (var nodeEdges in GraphAdjacencyList.Values)
                {
                    amountOfEdges += nodeEdges.Count;
                }
                if (amountOfEdges == amountOfNodes - 1)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool HasStartingNode()
        {
            return GraphAdjacencyList.Keys.Where(x => x.IsStartNode == true).Any();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool HasEndNode()
        {
            return GraphAdjacencyList.Keys.Where(x => x.IsEndNode == true).Any();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int AmountOfEdges()
        {
            var totalEdges = 0;
            foreach (var item in GraphAdjacencyList.Values)
            {
                totalEdges += item.Count;
            }
            if (!IsDirectedGraph)
            {
                return totalEdges / 2;
            }
            else
            {
                return totalEdges;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexNode"></param>
        /// <returns></returns>
        public bool TryRemoveVertex(TVertex vertexNode)
        {
            var vertexRemoved = false;
            if (HasVertex(vertexNode))
            {
                vertexRemoved = GraphAdjacencyList.Remove(vertexNode);
                if (vertexRemoved)
                {
                    foreach (TVertex vertex in GraphAdjacencyList.Keys)
                    {
                        LinkedList<TEdge> edges = GetEdges(vertex);
                        foreach (TEdge edge in edges)
                        {
                            if (edge.GetAdjacentVertex().GetNodeIdentifier() == vertexNode.GetNodeIdentifier())
                            {
                                TryRemoveEdge(vertex, edge);
                            }
                        }
                    }
                }
            }

            return vertexRemoved;
        }
    }
}
