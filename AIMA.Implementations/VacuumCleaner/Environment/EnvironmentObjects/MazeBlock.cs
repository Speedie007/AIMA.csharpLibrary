using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.Implementations.VacuumCleaner.Environment.EnvironmentObjects
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    
    public partial class MazeBlock<TPrecept, TAction> : IEnvironmentObject
        where TPrecept : BasePrecept, new()
        where TAction : BaseAction, new()
          
    {

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public XYLocation GridLocation { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public Stack<Dirt> DirtPiles { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public IAgent< TPrecept, TAction>? Agent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsDirty
        {
            get
            {
                return DirtPiles.Count > 0;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool LocationHasAgent
        { get { return Agent != null; } }


        #endregion

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="xCoordinate"></param>
        /// <param name="yCoordinate"></param>
        public MazeBlock(int xCoordinate, int yCoordinate) : this(xCoordinate, yCoordinate, new List<Dirt>(), null)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="xCoordinate"></param>
        /// <param name="yCoordinate"></param>
        /// <param name="dirtPiles"></param>
        public MazeBlock(int xCoordinate, int yCoordinate, List<Dirt> dirtPiles) : this(xCoordinate, yCoordinate, dirtPiles, null)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="xCoordinate"></param>
        /// <param name="yCoordinate"></param>
        /// <param name="dirtPiles"></param>
        /// <param name="agent"></param>
        public MazeBlock(int xCoordinate, int yCoordinate, List<Dirt> dirtPiles, IAgent< TPrecept, TAction>? agent)
        {
            GridLocation = new XYLocation(xCoordinate, yCoordinate);
            DirtPiles = new Stack<Dirt>(dirtPiles);
            Agent = agent;
        }
        #endregion

        #region Methods

        #endregion
    }
}
