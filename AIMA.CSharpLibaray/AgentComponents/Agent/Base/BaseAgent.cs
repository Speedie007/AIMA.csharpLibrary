using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Interface;
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
    /// 10 May
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public abstract partial class BaseAgent<TPrecept, TAction> :
        IAgent<TPrecept, TAction>,
        IAgentEvents<TPrecept, TAction>,
        IAgentEventFeedBack<TPrecept, TAction>
            where TAction : BaseAction, new()
            where TPrecept : BasePrecept, new()
    {

        #region Properties
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public static BaseAgentProgram<TPrecept, TAction> AgentProgram { get; private set; }
        /// <summary>
        /// Bool Property, Defining if the the agtent is currently alive/active.
        /// </summary>
        public bool IsAlive { get; set; }
        /// <summary>
        /// Read-only property, used to reference the assinged Performance measure used by the agent.
        /// </summary>
        /// 
        public BasePerformanceMeasure PerformaceMeasure { get; private set; }
        #endregion

        #region Cstor
        /// <summary>
        /// Empty Defalt Constructor, initailises te agent with the default agent program, Default Preformance Measure implementation, and instantiates the agent as alive(True)
        /// </summary>
        protected BaseAgent() : this(
            new DefaultAgentProgram<TPrecept, TAction>(),
            new DefaultPerformanceMeasure(),
            true)
        { }

        /// <summary>
        /// Agent Constructor, requires the implementation of the Agent's program, performance measue to implement, and wheather the agent is alive from instantiation.
        /// </summary>
        /// <param name="agentProgram">The Agent Program serves as the Agent's function(Logic implementation).</param>
        /// <param name="isAlive">Bool, Defining if the the agtent is alive/active when instantiated.</param>
        /// <param name="performanceMeasure">The Performance Measure type assigned to the agent.</param>
        protected BaseAgent(
            BaseAgentProgram<TPrecept, TAction> agentProgram,
            BasePerformanceMeasure performanceMeasure,
            bool isAlive)
        {
            AgentProgram = agentProgram;
            IsAlive = isAlive;
            PerformaceMeasure = performanceMeasure;
            InitialiseAgentProgram();
        }
        #endregion

        #region Agent Events
        /// <summary>
        /// 
        /// </summary>
        public event PerformanceMeasureEventHandlers.AgentPerformanceMeasureUpdatedEventHandler<TPrecept, TAction>? PerformanceMeasureUpdatedEventHandler;
        /// <summary>
        /// 
        /// </summary>
        public event AgentEventHandlers.AgentNotificationEventHandler<TPrecept, TAction>? AgentNotificationEventHandler;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentNotificationEventArgs"></param>
        public virtual void OnAgentMessageNotification(AgentNotificationEventArgs<TPrecept, TAction> agentNotificationEventArgs)
        {
            AgentNotificationEventHandler?.Invoke(agentNotificationEventArgs);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentPerformanceMeasureUpdatedEventArgs"></param>
        public virtual void OnAgentPerformanceMeasureUpdated(AgentPerformanceMeasureUpdatedEventArgs<TPrecept, TAction> agentPerformanceMeasureUpdatedEventArgs)
        {
            PerformanceMeasureUpdatedEventHandler?.Invoke(agentPerformanceMeasureUpdatedEventArgs);
        }
        #endregion

        #region Methods


        /// <inheritdoc/>
        public TPrecept PollAgentSensorsAsync(LinkedDictonarySet<IEnviromentObject> EnvironmentObjects)
        {
            TPrecept precept = new();
            if (AgentProgram != null)
                //Poll the current agent sensors to build the agents surrent precept of the enviroment it is in.
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
        public virtual void ProcessAgentAcuators(TAction action, LinkedDictonarySet<IEnviromentObject> environmentObjects)
        {
            if (action is not null && AgentProgram is not null)
                 AgentProgram.ProcessAgentActionFunction?.Invoke(environmentObjects, action, this); 
        }

        /// <summary>
        /// 
        /// </summary>
        public abstract void InitialiseAgentProgram();


        #endregion
    }
}
