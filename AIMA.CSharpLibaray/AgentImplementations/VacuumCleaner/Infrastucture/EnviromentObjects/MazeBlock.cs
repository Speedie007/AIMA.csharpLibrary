using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts;
using AIMA.CSharpLibrary.Common.DataStructure;
using NUnit.Framework;
using System.Collections.Generic;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Infrastucture.EnviromentObjects
{
    public partial class MazeBlock<TPrecept, TAction> : IEnvironmentObject
        where TPrecept : BaseAgentPrecept, new()
        where TAction : BaseAgentAction, new()
    {
        public enum EnumLocationState
        {
            LocationClean = 10,
            LocationDirty = 20
        }
        #region Properties
        public XYLocation GridLocation { get; private set; }
        public List<Dirt> DirtPiles { get; private set; }

        public IAgent<TPrecept, TAction>? Agent { get; set; }

        public bool IsDirty
        {
            get
            {
                return DirtPiles.Any();
            }
        }


        #endregion

        #region Cstor
        public MazeBlock(int xCoordinate, int yCoordinate) : this(xCoordinate, yCoordinate, new List<Dirt>(), null)
        {

        }
        public MazeBlock(int xCoordinate, int yCoordinate, List<Dirt> dirtPiles) : this(xCoordinate, yCoordinate, dirtPiles, null)
        {

        }

        public MazeBlock(int xCoordinate, int yCoordinate, List<Dirt> dirtPiles, IAgent<TPrecept, TAction>? agent)
        {
            GridLocation = new XYLocation(xCoordinate, yCoordinate);
            DirtPiles = new List<Dirt>(dirtPiles);
            Agent = agent;
        }
        #endregion

        #region Methods

        #endregion
    }
}
