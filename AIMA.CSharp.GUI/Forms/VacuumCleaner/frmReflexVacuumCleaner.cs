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
using AIMA.Implementations.VacuumCleaner.PerformanceMeasure;
using AIMA.Implementations.VacuumCleaner.Precept;

namespace AIMA.CSharp.GUI.Forms.VacuumCleaner
{
    /// <summary>
    /// 
    /// </summary>
    public partial class frmReflexVacuumCleaner : BaseForm,
        IEnvironmentEventFeedBack<VacuumCleanerPerformanceMeasure, ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction>,
        IAgentEventFeedBack<VacuumCleanerPerformanceMeasure, VacuumCleanerPrecept, VacuumCleanerAction>
    {
        // private readonly IEnvironmentFactory _environmentFactory;
        private delegate void SafeCallDelegate(string text);
        /// <summary>
        /// 
        /// </summary>
        protected VacuumCleanerEnvironment<VacuumCleanerPerformanceMeasure, ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> AgentEnvironment { get; private set; }
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
        public void OnAgentActed(EnvironmentAgentActedEventArgs<VacuumCleanerPerformanceMeasure, ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> args)
        {
            
            WriteTextSafe($"Agent Acted: {args.Agent.GetType().Name} - ActionExecuted:{args.ActionExecuted.ActionName}-{DateTime.Now}" + Environment.NewLine);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public void OnAgentAdded(EnvironmentAgentAddedEventArgs<VacuumCleanerPerformanceMeasure, ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> args)
        {
            WriteTextSafe($"Agent Added: {args.AgentAdded.GetType().Name} -To AgentEnvironment:{args.SourceEnvironment.GetType().Name}-{DateTime.Now}" + Environment.NewLine);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public void OnAgentRemoved(EnvironmentAgentRemovedEventArgs<VacuumCleanerPerformanceMeasure, ReflexVacuumCleanerAgent, VacuumCleanerPrecept, VacuumCleanerAction> args)
        {
            WriteTextSafe($"Agent Removed: {args.AgentRemoved.GetType().Name} - From AgentEnvironment:{nameof(args.SourceEnvironment)}-{DateTime.Now}" + Environment.NewLine);
        }

        private void frmReflexVacuumCleaner_Load(object sender, EventArgs e)
        {
            gbVacuumCleanerEnviromentView.Text = "Vacuum Cleaner AgentEnvironment";
        }

        private void frmReflexVacuumCleaner_Shown(object sender, EventArgs e)
        {


        }

        private async void button2_Click(object sender, EventArgs e)
        {
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
                        agent.OnAgentMessageNotification( new AgentNotificationEventArgs<VacuumCleanerPerformanceMeasure, VacuumCleanerPrecept, VacuumCleanerAction>(agent, "Agent Died due to early cancellation234."));
                    }
                }
            }
            finally
            {
                cancellationSource.Dispose();
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (cancellationSource.Token.CanBeCanceled)
                cancellationSource.Cancel(true);
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentNotificationEventArgs"></param>
        public void OnAgentMessageNotification(
            AgentNotificationEventArgs<VacuumCleanerPerformanceMeasure, VacuumCleanerPrecept, VacuumCleanerAction> agentNotificationEventArgs)
        {
            WriteTextSafe($"Agent Notification: {agentNotificationEventArgs.Agent.GetType().Name} - Message:{agentNotificationEventArgs.AgentMessage}-{DateTime.Now}" + Environment.NewLine);
        }
        /// <summary>
        /// /
        /// </summary>
        /// <param name="agentPerformanceMeasureUpdatedEventArgs"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void OnAgentPerformanceMeasureUpdated(
            AgentPerformanceMeasureUpdatedEventArgs<VacuumCleanerPerformanceMeasure, VacuumCleanerPrecept, VacuumCleanerAction> agentPerformanceMeasureUpdatedEventArgs)
        {
            WriteTextSafe(agentPerformanceMeasureUpdatedEventArgs.PerformanceMeasure.ToString());
        }

        

         
    }
}
