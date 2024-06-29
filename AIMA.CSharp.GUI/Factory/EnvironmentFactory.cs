using AIMA.CSharp.GUI.Factory.Interfaces;
using AIMA.CSharp.GUI.Forms.VacuumCleaner;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures;
using AIMA.Implementations.VacuumCleaner.Actions;
using AIMA.Implementations.VacuumCleaner.Agents;
using AIMA.Implementations.VacuumCleaner.Environment;
using AIMA.Implementations.VacuumCleaner.Environment.EnvironmentObjects;
using AIMA.Implementations.VacuumCleaner.PerformanceMeasure;
using AIMA.Implementations.VacuumCleaner.Precept;
using AIMA.Implementations.VacuumCleaner.VacuumCleanerPrograms;

namespace AIMA.CSharp.GUI.Factory
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EnvironmentFactory : IEnvironmentFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public EnvironmentFactory()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="frm"></param>
        /// <returns></returns>
        public VacuumCleanerEnvironment< ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> PrepareReflexVacuumCleanerEnvironment(frmReflexVacuumCleaner frm)
        {
            var environment = new VacuumCleanerEnvironment< ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction>(false);

            // frm.BindEnvironmentEvents();
            environment.AgentActedEvent += frm.OnAgentActed;
            environment.AgentAddedEvent += frm.OnAgentAdded;
            environment.AgentRemovedEvent += frm.OnAgentRemoved;

            //Build the required Agent
            var reflexAgent = new ReflexVacuumCleanerAgent(new ReflexVacuumCleanerAgentProgram(),
                new VacuumCleanerPerformanceMeasure(),
                true);
            reflexAgent.AgentNotificationEvent += frm.OnAgentMessageNotification;
            reflexAgent.PerformanceMeasureUpdatedEvent += frm.OnAgentPerformanceMeasureUpdated;
            environment.AddAgent(reflexAgent);

            //build the required environment
            var grid = new TableLayoutPanel();
            grid.ColumnCount = 2;
            grid.RowCount = 1;
            grid.Dock = DockStyle.Fill;
            grid.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;

            var locationA = new Panel();

            locationA.BorderStyle = BorderStyle.Fixed3D;

            var btn = new Button();
            btn.Text = "testing btn";
            btn.UseVisualStyleBackColor = true;
            //btn.Dock = DockStyle.Fill;
            locationA.Controls.Add(btn);

            grid.Controls.Add(locationA, 1, 1);
            var container = frm.Controls.Find("gbVacuumCleanerEnvironmentView", true);
            container[0].Controls.Add(grid);

            environment.AddEnvironmentObject(new MazeBlock< VacuumCleanerPrecept, VacuumCleanerAction>(1, 1, new List<Dirt>() { new Dirt() }));
            environment.AddEnvironmentObject(new MazeBlock< VacuumCleanerPrecept, VacuumCleanerAction>(2, 1, new List<Dirt>() { new Dirt() }, reflexAgent));

            return environment;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="frm"></param>
        /// <returns></returns>
        public VacuumCleanerEnvironment< ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> BuildSimpleReflexVacuumCleanerEnvironment(frmSimpleReflexVacuumCleaner frm)
        {
            var environment = new VacuumCleanerEnvironment< ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction>();

            return environment;
        }
    }
}
