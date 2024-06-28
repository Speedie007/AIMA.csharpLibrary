using AIMA.CSharp.GUI.Factory.Interfaces;
using AIMA.CSharp.GUI.Forms.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Agent;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Environment;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.PerformanceMeasure;
using AIMA.Implementations.VacuumCleaner.Actions;
using AIMA.Implementations.VacuumCleaner.Agents;
using AIMA.Implementations.VacuumCleaner.Environment;
using AIMA.Implementations.VacuumCleaner.Precept;
using System.Text;
using AIMA.CSharpLibrary.AgentComponents.Common;
using AIMA.CSharpLibrary.Common.Extensions;

namespace AIMA.CSharp.GUI.Forms.VacuumCleaner
{
    /// <summary>
    /// 
    /// </summary>
    public partial class frmReflexVacuumCleaner : BaseForm,
        IEnvironmentEventFeedBack<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction>,
        IAgentEventFeedBack<VacuumCleanerPrecept, VacuumCleanerAction>
    {
        // private readonly IEnvironmentFactory _environmentFactory;
        private delegate void SafeCallDelegate(string text);
        /// <summary>
        /// 
        /// </summary>
        protected VacuumCleanerEnvironment<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> AgentEnvironment { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="environmentFactory"></param>
        public frmReflexVacuumCleaner(IEnvironmentFactory environmentFactory)
        {
            InitializeComponent();
            AgentEnvironment = environmentFactory.PrepareReflexVacuumCleanerEnvironment(this);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public void OnAgentActed(EnvironmentAgentActedEventArgs<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> args)
        {
            
            var sb = new StringBuilder();
            sb.AppendLine($"Agent Acted: {args.Agent.GetType().Name}");
            sb.AppendLine($"Action Executed:{args.ActionExecuted.GetType().Name}");
            WriteTextSafe(sb.ToString().FormatStringToHaveSpaces());
            //WriteTextSafe($"Agent Acted: {args.Agent.GetType().Name} - ActionExecuted:{args.ActionExecuted.ActionName}-{DateTime.Now}" + Environment.NewLine);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public void OnAgentAdded(EnvironmentAgentAddedEventArgs<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> args)
        {
            WriteTextSafe($"Agent Added: {args.AgentAdded.GetType().Name} -To AgentEnvironment:{args.SourceEnvironment.GetType().Name}-{DateTime.Now}" + Environment.NewLine);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public void OnAgentRemoved(EnvironmentAgentRemovedEventArgs<ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> args)
        {
            WriteTextSafe($"Agent Removed: {args.AgentRemoved.GetType().Name} - From AgentEnvironment:{nameof(args.SourceEnvironment)}-{DateTime.Now}" + Environment.NewLine);
        }

        private void frmReflexVacuumCleaner_Load(object sender, EventArgs e)
        {
            gbVacuumCleanerEnvironmentView.Text = "Vacuum Cleaner AgentEnvironment";
        }

        private void frmReflexVacuumCleaner_Shown(object sender, EventArgs e)
        {


        }



        private void Button3_Click(object sender, EventArgs e)
        {

        }
        private void WriteTextSafe(string text)
        {

            if (txtOne.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                txtOne.Invoke(d, new object[] { text });
            }
            else
            {
                txtOne.Text = text;
            }
        }
        private void WriteTextSafePerformanceMeasure(string text)
        {

            if (txtOne.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                txtPerformanceMeasure.Invoke(d, new object[] { text });
            }
            else
            {
                txtPerformanceMeasure.Text = text;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentNotificationEventArgs"></param>
        public void OnAgentMessageNotification(
            AgentNotificationEventArgs<VacuumCleanerPrecept, VacuumCleanerAction> agentNotificationEventArgs)
        {
            WriteTextSafe($"Agent Notification: {agentNotificationEventArgs.Agent.GetType().Name} - Message:{agentNotificationEventArgs.AgentMessage}-{DateTime.Now}" + Environment.NewLine);
        }
        /// <summary>
        /// /
        /// </summary>
        /// <param name="agentPerformanceMeasureUpdatedEventArgs"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void OnAgentPerformanceMeasureUpdated(
            AgentPerformanceMeasureUpdatedEventArgs<VacuumCleanerPrecept, VacuumCleanerAction> agentPerformanceMeasureUpdatedEventArgs)
        {
            WriteTextSafePerformanceMeasure(agentPerformanceMeasureUpdatedEventArgs.PerformanceMeasure.ToString());
        }



        private async void btnStartStepping_Click(object sender, EventArgs e)
        {
            btnStartStepping.Enabled = false;
            btnStopStepping.Enabled = true;
            cancellationSource = new CancellationTokenSource();

            try
            {
                foreach (var agent in AgentEnvironment.GetAgents())
                {
                    agent.IsAlive = true;
                }
                await AgentEnvironment.StepUntilDoneAsync(cancellationSource.Token);
            }
            catch (OperationCanceledException)
            {
                foreach (var agent in AgentEnvironment.GetAgents())
                {
                    if (agent.IsAlive)
                    {
                        agent.IsAlive = false;
                        agent.OnAgentMessageNotification(new AgentNotificationEventArgs<VacuumCleanerPrecept, VacuumCleanerAction>(agent, "Agent Died due to early cancellation234."));
                    }
                }
            }
            finally
            {
                cancellationSource.Dispose();
            }
        }

        private void btnStopStepping_Click(object sender, EventArgs e)
        {
            btnStartStepping.Enabled = true;
            btnStopStepping.Enabled = false;
            if (cancellationSource.Token.CanBeCanceled)
                cancellationSource.Cancel(true);
        }
    }
}
