using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Infrastucture.EnviromentObjects
{
    public partial class MazeBlock : IEnvironmentObject
    {
        #region Properties
        public XYLocation GridLocation { get; private set; }
        public List<Dirt> DirtPiles { get; set; }
        public bool IsDirty
        {
            get
            {
                return DirtPiles.Any();
            }
        }
        #endregion

        #region Cstor
        public MazeBlock(int xCoordinate, int yCoordinate, List<Dirt> dirtPiles)
        {
            GridLocation = new XYLocation(xCoordinate, yCoordinate);
            DirtPiles = new List<Dirt>(dirtPiles);
        }
        #endregion

        #region Methods

        #endregion
    }
}
