using AIMA.CSharp.GUI.Factory.Interfaces;
using AIMA.CSharp.GUI.Forms.Base;
using AIMA.CSharpLibrary.AgentComponents.Actions.Interface;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Interface;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Agent;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Enviroment;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.PerformaneMeasure;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Interface;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Agents;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Enviroment;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept;
using System.Threading;

namespace AIMA.CSharp.GUI.Forms.VacuumCleaner
{
    public partial class frmReflexVacuumCleaner : BaseForm,
        IEnviromentEventFeedBack<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction>,
        IAgentEventFeedBack<VacuumCleanerPrecept, VacuumCleanerAction>
    {
        // private readonly IEnviromentFactory _enviromentFactory;

        protected VacuumCleanerEnviroment<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> AgentEnviroment { get; private set; }

        public frmReflexVacuumCleaner(IEnviromentFactory enviromentFactory)
        {
            InitializeComponent();
            AgentEnviroment = enviromentFactory.PrepareRelexVacuumCleanerEnviroment(this);
        }

        public void OnAgentActed(EnviromentAgentActedEventArgs<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> args)
        {
            txtOne.AppendText($"Agent Acted: {args.Agent.GetType().Name} - ActionExecuted:{args.ActionExecuted.ActionName}-{DateTime.Now}" + Environment.NewLine);
        }

        public void OnAgentAdded(EnviromentAgentAddedEventArgs<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> args)
        {
            txtOne.AppendText($"Agent Added: {args.AgentAdded.GetType().Name} -To AgentEnviroment:{args.SourceEnviroment.GetType().Name}-{DateTime.Now}" + Environment.NewLine);
        }

        public void OnAgentRemoved(EnviromentAgentRemovedEventArgs<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> args)
        {
            txtOne.AppendText($"Agent Removed: {args.AgentRemoved.GetType().Name} - From AgentEnviroment:{nameof(args.SourceEnviroment)}-{DateTime.Now}" + Environment.NewLine);
        }

        private void frmReflexVacuumCleaner_Load(object sender, EventArgs e)
        {
            gbVacuumCleanerEnviromentView.Text = "Vacuum Cleaner AgentEnviroment";
        }

        private void frmReflexVacuumCleaner_Shown(object sender, EventArgs e)
        {


        }

        private async void button2_Click(object sender, EventArgs e)
        {
            cancellationSource = new CancellationTokenSource();

            try
            {
                foreach (var agent in AgentEnviroment.GetAgents())
                {
                    agent.IsAlive = true;
                }
                await AgentEnviroment.StepUntilDoneAsync(cancellationSource.Token);
                var tt = "";
            }
            catch (OperationCanceledException)
            {
                foreach (var agent in AgentEnviroment.GetAgents())
                {
                    if (agent.IsAlive)
                    {
                        agent.IsAlive = false;
                        agent.OnAgentMessageNotification(
                           new AgentNotificationEventArgs<VacuumCleanerPrecept, VacuumCleanerAction>(agent,
                                                                                       "Agent Died due to early cancellation234."));
                    }
                }
            }
            finally
            {
                cancellationSource.Dispose();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cancellationSource.Token.CanBeCanceled)
                cancellationSource.Cancel();
        }

        public void OnAgentMessageNotification(AgentNotificationEventArgs<VacuumCleanerPrecept, VacuumCleanerAction> agentNotificationEventArgs)
        {
            txtOne.AppendText($"Agent Removed: {agentNotificationEventArgs.Agent.GetType().Name} - Message:{agentNotificationEventArgs.AgentMessage}-{DateTime.Now}" + Environment.NewLine);
        }

        public void OnAgentPerformanceMeasureUpdated(AgentPerformanceMeasureUpdatedEventArgs<VacuumCleanerPrecept, VacuumCleanerAction> agentPerformanceMeasureUpdatedEventArgs)
        {
            throw new NotImplementedException();
        }
    }
}
