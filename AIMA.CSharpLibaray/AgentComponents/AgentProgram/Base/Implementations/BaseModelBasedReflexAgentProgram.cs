using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules;
using AIMA.CSharpLibrary.AgentComponents.Models.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.AgentComponents.State.Base;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.Base.Implementations
{
    /// <summary>
    /// 16 june
    /// </summary>
    /// <typeparam name="TPrecept"><inheritdoc/></typeparam>
    /// <typeparam name="TAction"><inheritdoc/></typeparam>
    /// <typeparam name="TState">TODO:</typeparam>
    /// <typeparam name="TModel">TODO:</typeparam>
    public abstract partial class BaseModelBasedReflexAgentProgram<TPrecept, TAction, TState, TModel> : 
        BaseAgentProgram<TPrecept, TAction>
        where TPrecept : BasePrecept, new()
        where TAction : BaseAction, new()
        where TState : BaseState, new()
        where TModel : BaseModel, new()
    {

        #region Properties
       
        /// <value>
        /// Agent action, the most recent action, initially default => NoOperation.
        /// </value>
        public TAction LastActionExecuted { get; private set; }
       
        /// <value>
        /// AgentModel, a description of how the next state depends on current state and action.
        /// </value>
        public TModel AgentModel { get; private set; }

        /// <value>
        /// persistent: state, the agent's current conception of the world state.
        /// </value>
        public TState CurrentState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        protected HashSet<Rule<TAction>> Rules { get; private set; }
        #endregion

        #region Cstor
        /// <summary>
        /// Constructor for the Model Based Reflex Agent Program
        /// </summary>
        public BaseModelBasedReflexAgentProgram(): base()
        {
            LastActionExecuted = new TAction();
            CurrentState = new TState();
            AgentModel = new TModel();
            Rules = new HashSet<Rule<TAction>>();
            InitializeAgentProgramComponents();
        }

        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        /// <param name="action"></param>
        /// <param name="percept"></param>
        /// <param name="model">A Description of how the next state dependes on the current atate and action.</param>
        /// <returns></returns>
        protected abstract TState UpdateState(TState state, TAction action, TPrecept percept, TModel model);


        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="percept"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public override TAction ProcessAgentFunction(TPrecept percept)
        {
            CurrentState = UpdateState(CurrentState, LastActionExecuted, percept, AgentModel);
            Rule<TAction> rule = RuleMatch(CurrentState, Rules);
            LastActionExecuted = (rule is not null) ? rule.ResultantAction : new();
            return LastActionExecuted;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        /// <param name="rules"></param>
        /// <returns></returns>
        protected virtual  Rule<TAction> RuleMatch(TState state, HashSet<Rule<TAction>> rules)
        {
            return rules.FirstOrDefault(r => r.EvaluateRule(state)) is Rule<TAction> rule ? rule : new();  
        }
        #endregion



    }
}
