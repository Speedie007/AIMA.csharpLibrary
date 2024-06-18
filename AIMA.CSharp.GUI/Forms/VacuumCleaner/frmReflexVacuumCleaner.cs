using AIMA.CSharp.GUI.Factory.Interfaces;
using AIMA.CSharp.GUI.Forms.Base;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Enviroment;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Agents;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Enviroment;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept;

namespace AIMA.CSharp.GUI.Forms.VacuumCleaner
{
    public partial class frmReflexVacuumCleaner : BaseForm, IEnviromentEventFeedBack<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction>
    {
        protected VacuumCleanerEnviroment<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> Enviroment { get; private set; }
        
        public frmReflexVacuumCleaner(IEnviromentFactory enviromentFactory)//:base(enviromentFactory)
        {

            InitializeComponent();

            Enviroment = enviromentFactory.BuildRelexVacuumCleanerEnviroment(this);

        }



        public void OnAgentActed(EnviromentAgentActedEventArgs<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> args)
        {
            txtOne.AppendText($"Agent Acted: {args.Agent.GetType().Name} - Action:{args.Action.ActionName}-{DateTime.Now}");
        }

        public void OnAgentAdded(EnviromentAgentAddedEventArgs<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> args)
        {
            //txtPerformanceOutput
            txtOne.Text = $"Agent Added: {args.AgentAdded.GetType().Name} -To Enviroment:{args.SourceEnviroment.GetType().Name}-{DateTime.Now}";
            //txtOne.Text = $"Agent Added: {args.AgentAdded.GetType().Name} -To Enviroment:{args.SourceEnviroment.GetType().Name}-{DateTime.Now}"; 
        }

        public void OnAgentRemoved(EnviromentAgentRemovedEventArgs<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> args)
        {
            txtOne.AppendText($"Agent Removed: {args.AgentRemoved.GetType().Name} - From Enviroment:{nameof(args.SourceEnviroment)}-{DateTime.Now}");
        }

        private void frmReflexVacuumCleaner_Load(object sender, EventArgs e)
        {
            
        }

        private void frmReflexVacuumCleaner_Shown(object sender, EventArgs e)
        {
           
            
        }
    }
}
