using AIMA.csharpLibrary.Agent.AgentComponents.Base;
using AIMA.csharpLibrary.Agent.AgentProgramComponents.Interface;
using AIMA.csharpLibrary.AgentProgram.Agent.Interface;
using AIMA.csharpLibrary.Common.DataStructure;
using AIMA.csharpLibrary.Probability.Interfaces;

namespace AIMA.csharpLibrary.AgentProgram.Agent.Base
{
    public abstract partial class DecisionTheoreticAgent<TPrecept, TAction> : BaseAgent<TPrecept, TAction>
        where TAction : class, new()
    {
        IBeliefState<TPrecept, TAction> belief_state;
        TAction action;
        List<TAction> action_descriptions;
        protected DecisionTheoreticAgent(IAgentProgram<TPrecept, TAction> agentProgram, bool isAlive)
            : base(agentProgram, isAlive)
        {
            belief_state = new BeliefState<TPrecept,TAction>();
            action = new TAction();
            action_descriptions =  new List<TAction>();
        }

        /**
     * @param action_description 
     *			        permissible action descriptions
     * @param belief_state  
     *			  current belief state of the agent about the world
     * @return The next action to be taken.
     */
        public abstract List<Pair<IAction, Double>> CalulateActionProbabilities(List<IAction> action_description, IBeliefState<TPrecept, TAction> belief_state);

        /**
    * @param action_probabilities 
    *			          Probabilities of various outcomes
    * @return Action with the highest probability.
    */
        public abstract IAction action_with_highest_expected_utility(List<Pair<IAction, Double>> action_probabilities);
    }
}
