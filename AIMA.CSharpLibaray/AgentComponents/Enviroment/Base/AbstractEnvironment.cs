using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Common;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Events;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Enviroment;
using AIMA.CSharpLibrary.AgentComponents.Events.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Enviroment.Base
{
    /// <summary>
    /// <para>Base(Abstract) Enviroment used to represent the domain within wich the agent operates.</para>
    /// <list type="bullet">
    /// <item>
    /// <description>Author:Ravi Mohan</description>
    /// </item>
    /// <item>
    /// <description>Author:Ciaran O'Reilly</description>
    /// </item>
    /// <item>
    /// <description>Author:Ruediger Lunde</description>
    /// </item>
    /// <item>
    /// <description>Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental</description>
    /// </item>
    /// </list>
    ///<para>Date Created: 11 May 2024 - Date Last Updated: 16 June 2024</para>
    /// </summary>
    /// <typeparam name="TAgent">Type which represents the agent used in this enviroment</typeparam>
    /// <typeparam name="TAgentPrecept">Type which is used to represent percepts</typeparam>
    /// <typeparam name="TAgentAction">Type which is used to represent actions</typeparam>
    public abstract partial class AbstractEnvironment<TAgent, TAgentPrecept, TAgentAction> :
        IEnvironment<TAgent, TAgentPrecept, TAgentAction>,
        IEnviromentEvents<TAgent,TAgentPrecept, TAgentAction>,
        IEnviromentEventFeedBack<TAgent, TAgentPrecept, TAgentAction>
                where TAgentAction : AbstractAction, new()
                where TAgentPrecept : BasePrecept, new()
                where TAgent : AbstractAgent<TAgentPrecept, TAgentAction>, new()

    {
        #region Properties
        /// <summary>
        /// Note: Use LinkedHashSet's in order to ensure order is respected.
        /// Custom implementation is used within this libaray as C# does not Have A native LinkedHashSet as in the java libaray .
        /// </summary>
        protected LinkedHashSet<TAgent> Agents { get; private set; }
        /// <summary>
        /// Stores all the relevant objects which for part of the domian in which the agent operates.
        /// </summary>
        protected LinkedHashSet<IEnvironmentObject> EnvironmentObjects { get; private set; }
        #endregion

        #region Cstor
        /// <summary>
        /// Base Constructor for construction of the components of the required Enviroment domain.
        /// <list type="bullet">
        /// <item>
        /// <description>Initializes A container => (Agents) which houses all the relevant agents that will operate with this enviroment.</description>
        /// </item>
        /// <item>
        /// <description>Initializes A container => (EnviromantObjects) which houses all the relevant objects that will found and operated apon within this enviroment.</description>
        /// </item>
        /// </list>
        /// </summary>
        public AbstractEnvironment()
        {
            Agents = new LinkedHashSet<TAgent>();
            EnvironmentObjects = new LinkedHashSet<IEnvironmentObject>();
        }
        #endregion

        #region Events Handlers
        /// <summary>
        /// Will raise the OnAgentActed Event to Notify the caller of the agent that performed an action within the enviroment.
        /// </summary>
        public event EnviromentEventHandlers.AgentActedEventHandler<TAgent, TAgentPrecept, TAgentAction>? AgentActed;

        /// <summary>
        /// Will raise the OnAgentAdded Event to Notify the caller of the agent that was added to the enviroment.
        /// </summary>
        public event EnviromentEventHandlers.AgentAddedEventHandler<TAgent, TAgentPrecept, TAgentAction>? AgentAdded;

        /// <summary>
        /// Will raise the OnAgentRemoved Event to Notify the caller of the agent that was removed from the enviroment.
        /// </summary>
        public event EnviromentEventHandlers.AgentRemovedEventHandler<TAgent, TAgentPrecept, TAgentAction>? AgentRemoved;

        /// <summary>
        /// The event-invoking method that derived classes can override to process logic when an agent is added.
        /// </summary>
        /// <param name="args"></param>
        public virtual void OnAgentAdded(EnviromentAgentAddedEventArgs<TAgent,TAgentPrecept, TAgentAction> args)
        { AgentAdded?.Invoke(args); }
        /// <summary>
        /// The event-invoking method that derived classes can override to process logic when an agent is removed.
        /// </summary>
        /// <param name="args"></param>
        public virtual void OnAgentRemoved(EnviromentAgentRemovedEventArgs<TAgent, TAgentPrecept, TAgentAction> args)
        { AgentRemoved?.Invoke(args); }
        /// <summary>
        /// The event-invoking method that derived classes can override to process logic when an agent has performed an action.
        /// </summary>
        /// <param name="args"></param>
        public virtual void OnAgentActed(EnviromentAgentActedEventArgs<TAgent, TAgentPrecept, TAgentAction> args)
        { AgentActed?.Invoke(args); }
        #endregion

        #region Agent Methods
        /// <summary>
        /// Adds the Agent to the enviroment into the enviroment objects collection.
        /// </summary>
        /// <param name="agent">The Agent To be added into the enviroment.</param>
        public void AddAgent(TAgent agent)
        {
            Agents.Add(agent);
            AddEnvironmentObject(agent);
            OnAgentAdded(new EnviromentAgentAddedEventArgs<TAgent,TAgentPrecept, TAgentAction>(agent, this));
        }
        /// <summary>
        /// Retrieve A list of all the agents currently operating within this given enviroment.
        /// <list type="bullet">
        /// <item>
        /// <description>Item 1.</description>
        /// </item>
        /// <item>
        /// <description>Item 2.</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <returns><code>new List{TAgent}(Agents)</code>Return as A List but also ensure the caller cannot modify</returns>
        public List<TAgent> GetAgents()
        {
            return new List<TAgent>(Agents);
        }

        /// <summary>
        /// Removes A selected agent from the enviroment.
        /// </summary>
        /// <param name="agent">Agent To be removed.</param>
        public void RemoveAgent(TAgent agent)
        {
            //TODO: once the agents are operating on their own threads first check to verify if the agent is busy.
            //If so first cancel the current operation and then remove.
            Agents.Remove(agent);
            RemoveEnvironmentObject(agent);
            OnAgentRemoved(new EnviromentAgentRemovedEventArgs<TAgent, TAgentPrecept, TAgentAction>(agent, this));
        }
        #endregion

        #region Enviroment Methods
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="environmentObject"><inheritdoc/></param>
        public void AddEnvironmentObject(IEnvironmentObject environmentObject)
        {
            EnvironmentObjects.Add(environmentObject);
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public List<IEnvironmentObject> GetEnvironmentObjects()
        {
            // Return as A List but also ensure the caller cannot modify
            return new List<IEnvironmentObject>(EnvironmentObjects);
        }



        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public bool IsDone()
        {
            return Agents.Any(x => !x.IsAlive);
        }


        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="environmentObject"><inheritdoc/></param>
        public void RemoveEnvironmentObject(IEnvironmentObject environmentObject)
        {
            EnvironmentObjects.Remove(environmentObject);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public void Step()
        {
            foreach (TAgent agent in Agents)
            {
                if (agent.IsAlive)
                {
                    TAgentPrecept precept = agent.PollAgentSensors(EnvironmentObjects);
                    TAgentAction anAction = agent.ProcessAgentFunction(precept);
                    if (anAction.ActionName.Equals(AgentComponentDefaults.ACTION_NO_OPERATION))
                    {
                        agent.ExecuteNoOp();
                    }
                    else
                    {
                        agent.IsAlive = true;
                        agent.ExecuteAgentAction(anAction);
                    }
                    OnAgentActed(new EnviromentAgentActedEventArgs<TAgent, TAgentPrecept, TAgentAction>(agent, precept, anAction, this));
                }
            }
            CreateExogenousChange();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amountStepsToMoveForward"></param>
        public void Step(int amountStepsToMoveForward)
        {
            for (int i = 0; i < amountStepsToMoveForward; i++)
                Step();
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public void StepUntilDone()
        {
            while (!IsDone())
                Step();
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public abstract void CreateExogenousChange();

      
        #endregion

    }
}
