using AIMA.CSharp.GUI.Factory.Interfaces;
using AIMA.CSharp.GUI.Forms.VacuumCleaner;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Agents;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Enviroment;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Enviroment.EnviromentObjects;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.VacumCleanerPrograms;


namespace AIMA.CSharp.GUI.Factory
{
    public partial class EnviromentFactory : IEnviromentFactory
    {

        public EnviromentFactory()
        {

        }


        public VacuumCleanerEnviroment<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> PrepareRelexVacuumCleanerEnviroment(frmReflexVacuumCleaner frm)
        {
            var enviroment = new VacuumCleanerEnviroment<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction>();

            // frm.BindEnviromentEnvents();
            enviroment.AgentActedEvent += frm.OnAgentActed;
            enviroment.AgentAddedEvent += frm.OnAgentAdded;
            enviroment.AgentRemovedEvent += frm.OnAgentRemoved;

            //Build the required Agent
            var reflexAgent = new ReflexVacuumCleanerAgent(new ReflexVacuumCleanerAgentProgram(), new DefaultPerformanceMeasure(), true);
            reflexAgent.AgentNotificationEventHandler += frm.OnAgentMessageNotification;

            enviroment.AddAgent(reflexAgent);

            //build the required enviroment
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
            var contianer = frm.Controls.Find("gbVacuumCleanerEnviromentView", true);
            contianer[0].Controls.Add(grid);

            enviroment.AddEnvironmentObject(new MazeBlock<VacuumCleanerPrecept, VacuumCleanerAction>(1, 1, new List<Dirt>() { new Dirt() }));
            enviroment.AddEnvironmentObject(new MazeBlock<VacuumCleanerPrecept, VacuumCleanerAction>(1, 2, new List<Dirt>() { new Dirt() }, reflexAgent));
            
            return enviroment;
        }

        public VacuumCleanerEnviroment<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> BuildSimpleRelexVacuumCleanerEnviroment(frmSimpleReflexVacuumCleaner frm)
        {
            var enviroment = new VacuumCleanerEnviroment<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction>();

            return enviroment;
        }
    }
}
