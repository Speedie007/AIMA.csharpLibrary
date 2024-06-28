using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.AgentComponents.Events;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Agent;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.PerformanceMeasure;
using AIMA.CSharpLibrary.AgentComponents.Events.Interface;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Agent.Base
{
    /// <summary>
    /// 10 May
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    /// <typeparam name="TPerformanceMeasure"></typeparam>
    public abstract partial class BaseAgent<TPerformanceMeasure, TPrecept, TAction> :
        IAgent<TPerformanceMeasure, TPrecept, TAction>,
        IAgentEvents<TPerformanceMeasure, TPrecept, TAction>,
        IAgentEventFeedBack<TPerformanceMeasure, TPrecept, TAction>,
        IEquatable<BaseAgent<TPerformanceMeasure, TPrecept, TAction>?>
            where TAction : BaseAction, new()
            where TPrecept : BasePrecept, new()
            where TPerformanceMeasure : BasePerformanceMeasure, new()
    {
        #region Properties
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public static BaseAgentProgram<TPerformanceMeasure, TPrecept, TAction>? AgentProgram { get; private set; }
        /// <summary>
        /// Bool Property, Defining if the the agent is currently alive/active.
        /// </summary>
        public bool IsAlive { get; set; }
        /// <summary>
        /// Read-only property, used to reference the assigned Performance measure used by the agent.
        /// </summary>
        /// 
        public IPerformanceMeasure PerformanceMeasure { get; private set; }

        /// <value>
        /// 
        /// </value>
        public Guid AgentID { get; private set; }
        #endregion

        #region Cstor
        /// <summary>
        /// Empty Default Constructor, initialises te agent with the default agent program, Default Performance Measure implementation, and instantiates the agent as alive(True)
        /// </summary>
        protected BaseAgent() : this(
            new DefaultAgentProgram<TPerformanceMeasure, TPrecept, TAction>(),
            new DefaultPerformanceMeasure(),
            true){ }

        /// <summary>
        /// Agent Constructor, requires the implementation of the Agent's program, performance measure to implement, and whether the agent is alive from instantiation.
        /// </summary>
        /// <param name="agentProgram">The Agent Program serves as the Agent's function(Logic implementation).</param>
        /// <param name="isAlive">Bool, Defining if the the agent is alive/active when instantiated.</param>
        /// <param name="performanceMeasure"></param>
        protected BaseAgent(
            BaseAgentProgram<TPerformanceMeasure, TPrecept, TAction> agentProgram,
            IPerformanceMeasure performanceMeasure,
            bool isAlive)
        {
            AgentID = Guid.NewGuid();
            AgentProgram = agentProgram;
            IsAlive = isAlive;
            PerformanceMeasure = performanceMeasure;
            InitialiseAgentProgram();
        }
        #endregion

        #region Agent Events
        /// <summary>
        /// 
        /// </summary>
        public event PerformanceMeasureEventHandlers.AgentPerformanceMeasureUpdatedEventHandler<TPerformanceMeasure, TPrecept, TAction>? PerformanceMeasureUpdatedEvent;
        /// <summary>
        /// 
        /// </summary>
        public event AgentEventHandlers.AgentNotificationEventHandler<TPerformanceMeasure, TPrecept, TAction>? AgentNotificationEvent;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentNotificationEventArgs"></param>
        public virtual void OnAgentMessageNotification(AgentNotificationEventArgs<TPerformanceMeasure, TPrecept, TAction> agentNotificationEventArgs)
        {
            AgentNotificationEvent?.Invoke(agentNotificationEventArgs);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentPerformanceMeasureUpdatedEventArgs"></param>
        public virtual void OnAgentPerformanceMeasureUpdated(AgentPerformanceMeasureUpdatedEventArgs<TPerformanceMeasure, TPrecept, TAction> agentPerformanceMeasureUpdatedEventArgs)
        {
            PerformanceMeasureUpdatedEvent?.Invoke(agentPerformanceMeasureUpdatedEventArgs);
        }
        #endregion

        #region Methods


        /// <inheritdoc/>
        public TPrecept ProcessAgentSensors(LinkedDictonarySet<IEnvironmentObject> EnvironmentObjects)
        {
            TPrecept precept = new();
            if (AgentProgram != null)
                //Poll the current agent sensors to build the agents current precept of the environment it is in.
                precept = AgentProgram.SensorPollingFunction?.Invoke(EnvironmentObjects, this) is TPrecept agentPrecept ? agentPrecept : new();
            return precept;
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="percept"><inheritdoc/></param>
        /// <returns><typeparamref name="TAction"/><inheritdoc/></returns>
        public virtual TAction ProcessAgentFunction(TPrecept percept)
        {
            TAction action = new();
            if (percept is not null && AgentProgram is not null)
                action = AgentProgram.AgentPreceptToActionFunction?.Invoke(percept) is TAction agentAction ? agentAction : new();

            return action;
        }

        /// <inheritdoc/>
        public abstract void ExecuteNoOp();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="action"></param>
        /// <param name="environmentObjects"></param>
        public virtual void ProcessAgentActuators(TAction action, LinkedDictonarySet<IEnvironmentObject> environmentObjects)
        {
            if (action is not null && AgentProgram is not null)
                AgentProgram.ProcessAgentActionFunction?.Invoke(environmentObjects, action, this);
        }

        /// <summary>
        /// 
        /// </summary>
        public abstract void InitialiseAgentProgram();
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="obj"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public override bool Equals(object? obj)
        {
            return Equals(obj as BaseAgent<TPerformanceMeasure, TPrecept, TAction>);
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other"><inheritdoc/> In this case an Agent.</param>
        /// <returns><inheritdoc/></returns>
        public bool Equals(BaseAgent<TPerformanceMeasure, TPrecept, TAction>? other)
        {
            return other is not null &&
                   AgentID.Equals(other.AgentID);
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(AgentID);
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="left"><inheritdoc/></param>
        /// <param name="right"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public static bool operator ==(BaseAgent<TPerformanceMeasure, TPrecept, TAction>? left, BaseAgent<TPerformanceMeasure, TPrecept, TAction>? right)
        {
            return EqualityComparer<BaseAgent<TPerformanceMeasure, TPrecept, TAction>>.Default.Equals(left, right);
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="left"><inheritdoc/></param>
        /// <param name="right"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public static bool operator !=(BaseAgent<TPerformanceMeasure, TPrecept, TAction>? left, BaseAgent<TPerformanceMeasure, TPrecept, TAction>? right)
        {
            return !(left == right);
        }


        #endregion
    }
}
