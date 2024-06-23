using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Enviroment.EnviromentObjects;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Enviroment
{
    /// <summary>
    /// 16 June
    /// </summary>
    /// <typeparam name="TAgent"><inheritdoc/></typeparam>
    /// <typeparam name="TAgentPrecept"><inheritdoc/></typeparam>
    /// <typeparam name="TAgentAction"><inheritdoc/></typeparam>
    public partial class VacuumCleanerEnviroment<TAgent, TAgentPrecept, TAgentAction> : BaseEnvironment<TAgent, TAgentPrecept, TAgentAction>
            where TAgentAction : BaseAction, new()
            where TAgentPrecept : BasePrecept, new()
            where TAgent : BaseAgent<TAgentPrecept, TAgentAction>, new()    
    {
        /// <summary>
        /// Property indicating wheather the Exogenous Change within the eviroment may occur.
        /// </summary>
        public bool AllowExogenousChange { get; private set; }


        #region Cstor
        /// <summary>
        /// Vacuum Cleaner Enviroment Constructor.
        /// </summary>
        /// <param name="allowExogenousChange">Boolean, Indicates wheather Exogenous Change within the eviroment is allowed.
        /// <para>Default: false.</para>
        /// </param>
        public VacuumCleanerEnviroment(bool allowExogenousChange = false) : base()
        {
            AllowExogenousChange = allowExogenousChange;
        }
        #endregion

        /// <summary>
        /// <inheritdoc/>
        /// <para>To Simulate a real world enviroment in which a Vacuum Cleaner agent would operate external eneties or conditions could deposit dirt on any location.</para>
        /// </summary>
        public override void CreateExogenousChange()
        {
            if (AllowExogenousChange) {
                var rand = new Random();

                foreach (var enviromentObject in EnvironmentObjects.Where(x => x.GetType().Name.Equals(nameof(MazeBlock<TAgentPrecept, TAgentAction>))))//.ToList<MazeBlock<TAgentPrecept,TAgentAction>())
                {
                    if (rand.Next(101) >= 50)
                    {
                        var selectedLoaction = enviromentObject as MazeBlock<TAgentPrecept, TAgentAction>;
                        if (selectedLoaction != null)
                            selectedLoaction.DirtPiles.Add(new Dirt());
                    }
                }
            }
           
        }
    }
}
