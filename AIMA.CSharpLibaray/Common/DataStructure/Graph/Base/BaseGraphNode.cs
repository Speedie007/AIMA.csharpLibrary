using AIMA.CSharpLibrary.Common.DataStructure.Graph.Interface;

namespace AIMA.CSharpLibrary.Common.DataStructure.Graph.Base
{
    /// <summary>
    /// 28 June
    /// </summary>
    public abstract partial class BaseGraphNode : IGraphNode
    {
        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public NodeBaseContextEntity NodeDataContext { get; private set; }

        private int _Level;
        /// <summary>
        /// 
        /// </summary>
        public int Level
        {
            get => _Level;
            private set
            {
                if (value != _Level)
                {
                    var perviousLevel = _Level;
                    _Level = value;
                    //OnNodeLevelChanged?.Invoke(new NodeLevelEventArgs<TNodeContext>(this, perviousLevel, value));
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private bool _IsVisited;
        /// <summary>
        /// 
        /// </summary>
        public bool IsVisited
        {
            get => _IsVisited;
            private set
            {
                _IsVisited = value;
                if (IsVisited)
                {
                    //if (IsStartNode)
                    //    OnFirstNodeVisited?.Invoke(new FirstNodeVisitedEventArgs<TNodeContext>(this));

                    //if (IsEndNode)
                    //    OnLastNodeVisited?.Invoke(new LastNodeVisitedEventArgs<TNodeContext>(this, _Level));

                    //OnNodeVisited?.Invoke(new NodeVisitedEventArgs<TNodeContext>(this));
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsStartNode { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsEndNode { get; private set; }
        #endregion

        #region Event Handlers
        //public event NodeLevelEventHandler<TNodeContext>? OnNodeLevelChanged;
        //public event NodeVisitedEventHandler? OnNodeVisited;
        //public event FirstNodeVisitedEventHandler<TNodeContext>? OnFirstNodeVisited;
        //public event LastNodeVisitedEventHandler<TNodeContext>? OnLastNodeVisited;
        #endregion

        #region cstr
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nodeContext"></param>
        /// <param name="isStartNode"></param>
        /// <param name="isEndNode"></param>
        public BaseGraphNode(NodeBaseContextEntity nodeContext, bool isStartNode = false, bool isEndNode = false)
        {
            NodeDataContext = nodeContext;
            Level = 0;
            IsVisited = false;
            IsEndNode = isEndNode;
            IsStartNode = isStartNode;
        }

        //event NodeVisitedEventHandler<TNodeContext> INode<TNodeContext>.OnNodeVisited
        //{
        //    add
        //    {
        //        throw new NotImplementedException();
        //    }

        //    remove
        //    {
        //        throw new NotImplementedException();
        //    }
        //}


        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetNodeIdentifier()
        {
            return NodeDataContext.Id;
        }
        /// <summary>
        /// 
        /// </summary>
        public void IncrementLevel()
        {
            Level++;
        }
        /// <summary>
        /// 
        /// </summary>
        public void MarkNodeAsVisited()
        {
            IsVisited = true;
        }
        /// <summary>
        /// 
        /// </summary>
        public void ResetLevel()
        {
            _Level = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        public void ResetVisited()
        {
            _IsVisited = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(INode? other)
        {
            // this.NodeDataContext.GetType() == 
            if (other == null)
                return 1;
            if (GetHashCode() > other.GetHashCode())
                return 1;

            if (GetHashCode() < other.GetHashCode())
                return -1;

            return 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return NodeDataContext.Id.GetHashCode();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            var item = obj as NodeBaseContextEntity;

            if (item == null)
                return false;
            //if (item.GetType() == typeof(IWeightedEdge<decimal>))
            //{

            //}

            return NodeDataContext.Id.Equals(item.Id);

        }
        /// <summary>
        /// 
        /// </summary>
        public void SetAsStartingNode()
        {
            IsStartNode = true;
        }
        /// <summary>
        /// 
        /// </summary>
        public void SetAsEndNode()
        {
            IsEndNode = true;
        }
        /// <summary>
        /// 
        /// </summary>
        public void RemoveAsStartingNode()
        {
            IsStartNode = false;
        }
        /// <summary>
        /// 
        /// </summary>
        public void RemoveAsEndNode()
        {
            IsEndNode = false;
        }
        #endregion
    }
}
