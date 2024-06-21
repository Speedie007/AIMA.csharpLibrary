using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base.Implementations;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.VacumCleanerPrograms
{
    /// <summary>
    /// 15 june
    /// </summary>
    public partial class TableDrivenVacuumCleanerAgentProgram : AbstractTableDrivenAgentProgram<VacuumCleanerPrecept, VacuumCleanerAction>
    {
        /// <summary>
        /// 
        /// </summary>
        public TableDrivenVacuumCleanerAgentProgram() : base()
        {
            Initialize();
        }
        #region Cstor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="perceptsToActionMap"></param>
        public TableDrivenVacuumCleanerAgentProgram(Dictionary<List<VacuumCleanerPrecept>, VacuumCleanerAction> perceptsToActionMap) : base(perceptsToActionMap)
        {
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public override void Initialize()
        {
            Table = createPerceptsToActionMap();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static Dictionary<List<VacuumCleanerPrecept>, VacuumCleanerAction> createPerceptsToActionMap()
        {
            Dictionary<List<VacuumCleanerPrecept>, VacuumCleanerAction> result = new();

            var Location_A_Clean = new VacuumCleanerPrecept(new XYLocation(1, 1), false);
            var Location_A_Dirty = new VacuumCleanerPrecept(new XYLocation(1, 1), true);

            var Location_B_Clean = new VacuumCleanerPrecept(new XYLocation(2, 1), false);
            var Location_B_Dirty = new VacuumCleanerPrecept(new XYLocation(2, 1), true);

            // NOTE: While this particular result could be setup simply
            // using a few loops, the intent is to show how quickly a result
            // based approach grows and becomes unusable.
            //
            // Level 1: 4 states
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty }, new VacuumCleanerSuckAction());
            //
            // Level 2: 4x4 states
            // 1
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_B_Dirty }, new VacuumCleanerSuckAction());

            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_B_Dirty }, new VacuumCleanerSuckAction());

            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_B_Dirty }, new VacuumCleanerSuckAction());

            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_B_Dirty }, new VacuumCleanerSuckAction());


            //
            // Level 3: 4x4x4 states
            // 1-1
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_A_Clean, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_A_Clean, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_A_Clean, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_A_Clean, Location_B_Dirty }, new VacuumCleanerSuckAction());

            // 1-2
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_A_Dirty, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_A_Dirty, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_A_Dirty, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_A_Dirty, Location_B_Dirty }, new VacuumCleanerSuckAction());

            // 1-3
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_B_Clean, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_B_Clean, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_B_Clean, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_B_Clean, Location_B_Dirty }, new VacuumCleanerSuckAction());

            // 1-4
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_B_Dirty, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_B_Dirty, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_B_Dirty, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Clean, Location_B_Dirty, Location_B_Dirty }, new VacuumCleanerSuckAction());

            // 2-1
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_A_Clean, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_A_Clean, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_A_Clean, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_A_Clean, Location_B_Dirty }, new VacuumCleanerSuckAction());

            // 2-2
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_A_Dirty, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_A_Dirty, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_A_Dirty, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_A_Dirty, Location_B_Dirty }, new VacuumCleanerSuckAction());

            // 2-3
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_B_Clean, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_B_Clean, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_B_Clean, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_B_Clean, Location_B_Dirty }, new VacuumCleanerSuckAction());

            // 2-4
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_B_Dirty, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_B_Dirty, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_B_Dirty, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_A_Dirty, Location_B_Dirty, Location_B_Dirty }, new VacuumCleanerSuckAction());

            // 3-1
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_A_Clean, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_A_Clean, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_A_Clean, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_A_Clean, Location_B_Dirty }, new VacuumCleanerSuckAction());



            // 3-2
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_A_Dirty, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_A_Dirty, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_A_Dirty, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_A_Dirty, Location_B_Dirty }, new VacuumCleanerSuckAction());

            // 3-3
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_B_Clean, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_B_Clean, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_B_Clean, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_B_Clean, Location_B_Dirty }, new VacuumCleanerSuckAction());

            // 3-4
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_B_Dirty, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_B_Dirty, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_B_Dirty, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Clean, Location_B_Dirty, Location_B_Dirty }, new VacuumCleanerSuckAction());

            // 4-1
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_A_Clean, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_A_Clean, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_A_Clean, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_A_Clean, Location_B_Dirty }, new VacuumCleanerSuckAction());

            // 4-2
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_A_Dirty, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_A_Dirty, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_A_Dirty, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_A_Dirty, Location_B_Dirty }, new VacuumCleanerSuckAction());

            // 4-3
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_B_Clean, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_B_Clean, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_B_Clean, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_B_Clean, Location_B_Dirty }, new VacuumCleanerSuckAction());

            // 4-4
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_B_Dirty, Location_A_Clean }, new VacuumCleanerMoveRightAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_B_Dirty, Location_A_Dirty }, new VacuumCleanerSuckAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_B_Dirty, Location_B_Clean }, new VacuumCleanerMoveLeftAction());
            result.TryAdd(new List<VacuumCleanerPrecept>() { Location_B_Dirty, Location_B_Dirty, Location_B_Dirty }, new VacuumCleanerSuckAction());
           

            //
            // Level 4: 4x4x4x4 states
            // ...

            return result;
        }
    }
}
