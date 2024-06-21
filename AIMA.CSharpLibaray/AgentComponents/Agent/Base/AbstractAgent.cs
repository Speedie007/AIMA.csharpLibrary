using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Events;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Agent;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.PerformaneMeasure;
using AIMA.CSharpLibrary.AgentComponents.Events.Interface;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Agent.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public abstract partial class AbstractAgent<TPrecept, TAction> :
        IAgent<TPrecept, TAction>,
        IAgentEvents<TPrecept, TAction>,
        IAgentEventFeedBack<TPrecept, TAction>
            where TAction : AbstractAction, new()
            where TPrecept : BasePrecept, new()
    {

        #region Properties
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        protected AbstractAgentProgram<TPrecept, TAction> AgentProgram { get; private set; }
        /// <summary>
        /// Bool Property, Defining if the the agtent is currently alive/active.
        /// </summary>
        public bool IsAlive { get; set; }
        /// <summary>
        /// Read-only property, used to reference the assinged Performance measure used by the agent.
        /// </summary>
        /// 
        public BasePerformaceMeasure PerformaceMeasure { get; private set; }
        #endregion

        #region Cstor
        /// <summary>
        /// Empty Defalt Constructor, initailises te agent with the default agent program, Default Preformance Measure implementation, and instantiates the agent as alive(True)
        /// </summary>
        protected AbstractAgent() : this(new DefaultAgentProgram<TPrecept, TAction>(), new DefaultPerformanceMeasure(), true) { }

        /// <summary>
        /// Agent Constructor, requires the implementation of the Agent's program, performance measue to implement, and wheather the agent is alive from instantiation.
        /// </summary>
        /// <param name="agentProgram">The Agent Program serves as the Agent's function(Logic implementation).</param>
        /// <param name="isAlive">Bool, Defining if the the agtent is alive/active when instantiated.</param>
        /// <param name="performanceMeasure">The Performance Measure type assigned to the agent.</param>
        protected AbstractAgent(AbstractAgentProgram<TPrecept, TAction> agentProgram, BasePerformaceMeasure performanceMeasure, bool isAlive)
        {
            AgentProgram = agentProgram;
            IsAlive = isAlive;
            PerformaceMeasure = performanceMeasure;
            PerformanceMeasureUpdated += OnAgentPerformanceMeasureUpdated;
            AgentNotification += OnAgentNotification;
        }
        #endregion

        #region Agent Events
        /// <summary>
        /// 
        /// </summary>
        public event PerformanceMeasureEventHandlers.AgentPerformanceMeasureUpdatedEventHandler<TPrecept, TAction> PerformanceMeasureUpdated;
        /// <summary>
        /// 
        /// </summary>
        public event AgentEventHandlers.AgentNotificationEventHandler<TPrecept, TAction> AgentNotification;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentNotificationEventArgs"></param>
        public virtual void OnAgentNotification(AgentNotificationEventArgs<TPrecept, TAction> agentNotificationEventArgs)
        {
            AgentNotification?.Invoke(agentNotificationEventArgs);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentPerformanceMeasureUpdatedEventArgs"></param>
        public virtual void OnAgentPerformanceMeasureUpdated(AgentPerformanceMeasureUpdatedEventArgs<TPrecept, TAction> agentPerformanceMeasureUpdatedEventArgs)
        {
            PerformanceMeasureUpdated?.Invoke(agentPerformanceMeasureUpdatedEventArgs);
        }
        #endregion

        #region Methods


        /// <inheritdoc/>
        public virtual TPrecept PollAgentSensors(LinkedHashSet<IEnvironmentObject> EnvironmentObjects)
        {
            if (AgentProgram != null)
                //Poll the current agent sensors to build the agents surrent precept of the enviroment it is in.
                return AgentProgram.SensorPollingFunc?.Invoke(EnvironmentObjects, this) is TPrecept agentPrecept ? agentPrecept : new();
            else
                return new();
        }
        /// <inheritdoc/>
        public virtual TAction ProcessAgentFunction(TPrecept percept)
        {
            if (percept == null || AgentProgram == null)
            {
                return new();
            }
            else { return AgentProgram.AgentFunction?.Invoke(percept) is TAction agentAction ? agentAction : new(); }
        }

        /// <inheritdoc/>
        public abstract void ExecuteNoOp();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="action"></param>
        public abstract void ExecuteAgentAction(TAction action);


        #endregion
    }
}
