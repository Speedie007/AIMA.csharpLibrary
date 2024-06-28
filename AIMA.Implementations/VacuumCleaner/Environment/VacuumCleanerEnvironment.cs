using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Environment.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.Implementations.VacuumCleaner.Environment.EnvironmentObjects;

namespace AIMA.Implementations.VacuumCleaner.Environment
{
    /// <summary>
    /// 16 June
    /// </summary>
    /// <typeparam name="TAgent"><inheritdoc/></typeparam>
    /// <typeparam name="TPrecept"><inheritdoc/></typeparam>
    /// <typeparam name="TAction"><inheritdoc/></typeparam>
    
    public partial class VacuumCleanerEnvironment<TAgent, TPrecept, TAction> : BaseEnvironment< TAgent, TPrecept, TAction>
        where TPrecept : BasePrecept, new()
        where TAction : BaseAction, new()
         
        where TAgent : BaseAgent< TPrecept, TAction>, new()
    {
        /// <summary>
        /// Property indicating whether the Exogenous Change within the environment may occur.
        /// </summary>
        public bool AllowExogenousChange { get; private set; }


        #region Cstor
        /// <summary>
        /// Vacuum Cleaner Environment Constructor.
        /// </summary>
        /// <param name="allowExogenousChange">Boolean, Indicates whether Exogenous Change within the environment is allowed.
        /// <para>Default: false.</para>
        /// </param>
        public VacuumCleanerEnvironment(bool allowExogenousChange = false) : base()
        {
            AllowExogenousChange = allowExogenousChange;
        }
        #endregion

        /// <summary>
        /// <inheritdoc/>
        /// <para>To Simulate a real world environment in which a Vacuum Cleaner agent would operate external entities or conditions could deposit dirt on any location.</para>
        /// </summary>
        public override void CreateExogenousChange()
        {
            if (AllowExogenousChange)
            {
                var rand = new Random();

                foreach (var environmentObject in EnvironmentObjects.OfType<MazeBlock< TPrecept, TAction>>().ToList())//.ToList<MazeBlock<TPrecept,TAction>())
                {
                    if (rand.Next(101) >= 85)
                    {
                        if (environmentObject is MazeBlock< TPrecept, TAction> selectedLocation)
                            selectedLocation.DirtPiles.Push(new Dirt());
                    }
                }
            }

        }
    }
}
