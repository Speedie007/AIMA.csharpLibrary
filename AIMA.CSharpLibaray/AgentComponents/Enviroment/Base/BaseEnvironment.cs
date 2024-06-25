using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Common;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Interface;
using AIMA.CSharpLibrary.AgentComponents.Events;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Agent;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Enviroment;
using AIMA.CSharpLibrary.AgentComponents.Events.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;
using System.Threading;
using System.Threading.Tasks;

namespace AIMA.CSharpLibrary.AgentComponents.Enviroment.Base
{
    /// <summary>
    /// <para>Base(Base) Enviroment used to represent the domain within wich the agent operates.</para>
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
    public abstract partial class BaseEnvironment<TAgent, TAgentPrecept, TAgentAction> :
        IEnvironment<TAgent, TAgentPrecept, TAgentAction>,
        IEnviromentEvents<TAgent, TAgentPrecept, TAgentAction>,
        IEnviromentEventFeedBack<TAgent, TAgentPrecept, TAgentAction>
                where TAgentAction : BaseAction, new()
                where TAgentPrecept : BasePrecept, new()
                where TAgent : BaseAgent<TAgentPrecept, TAgentAction>, new()

    {
        #region Properties
        /// <summary>
        /// Note: Use LinkedDictonarySet's in order to ensure order is respected.
        /// Custom implementation is used within this libaray as C# does not Have A native LinkedDictonarySet as in the java libaray .
        /// </summary>
        protected LinkedDictonarySet<TAgent> Agents { get; private set; }
        /// <summary>
        /// Stores all the relevant objects which for part of the domian in which the agent operates.
        /// </summary>
        protected LinkedDictonarySet<IEnviromentObject> EnvironmentObjects { get; private set; }
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
        public BaseEnvironment()
        {
            Agents = new LinkedDictonarySet<TAgent>();
            EnvironmentObjects = new LinkedDictonarySet<IEnviromentObject>();
        }
        #endregion

        #region Events Handlers
        /// <summary>
        /// Will raise the OnAgentActed Event to Notify the caller of the agent that performed an action within the enviroment.
        /// </summary>
        public event EnviromentEventHandlers.AgentActedEventHandler<TAgent, TAgentPrecept, TAgentAction>? AgentActedEvent;

        /// <summary>
        /// Will raise the OnAgentAdded Event to Notify the caller of the agent that was added to the enviroment.
        /// </summary>
        public event EnviromentEventHandlers.AgentAddedEventHandler<TAgent, TAgentPrecept, TAgentAction>? AgentAddedEvent;

        /// <summary>
        /// Will raise the OnAgentRemoved Event to Notify the caller of the agent that was removed from the enviroment.
        /// </summary>
        public event EnviromentEventHandlers.AgentRemovedEventHandler<TAgent, TAgentPrecept, TAgentAction>? AgentRemovedEvent;

        /// <summary>
        /// The event-invoking method that derived classes can override to process logic when an agent is added.
        /// </summary>
        /// <param name="args"></param>
        public virtual void OnAgentAdded(EnviromentAgentAddedEventArgs<TAgent, TAgentPrecept, TAgentAction> args)
        { AgentAddedEvent?.Invoke(args); }
        /// <summary>
        /// The event-invoking method that derived classes can override to process logic when an agent is removed.
        /// </summary>
        /// <param name="args"></param>
        public virtual void OnAgentRemoved(EnviromentAgentRemovedEventArgs<TAgent, TAgentPrecept, TAgentAction> args)
        { AgentRemovedEvent?.Invoke(args); }
        /// <summary>
        /// The event-invoking method that derived classes can override to process logic when an agent has performed an action.
        /// </summary>
        /// <param name="args"></param>
        public virtual void OnAgentActed(EnviromentAgentActedEventArgs<TAgent, TAgentPrecept, TAgentAction> args)
        { AgentActedEvent?.Invoke(args); }
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
            OnAgentAdded(new EnviromentAgentAddedEventArgs<TAgent, TAgentPrecept, TAgentAction>(agent, this));
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
        public void AddEnvironmentObject(IEnviromentObject environmentObject)
        {
            EnvironmentObjects.Add(environmentObject);
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public List<IEnviromentObject> GetEnvironmentObjects()
        {
            // Return as A List but also ensure the caller cannot modify
            return new List<IEnviromentObject>(EnvironmentObjects);
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
        public void RemoveEnvironmentObject(IEnviromentObject environmentObject)
        {
            EnvironmentObjects.Remove(environmentObject);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public async Task StepAsync(CancellationToken cancellationToken)
        {
            foreach (TAgent agent in Agents)
            {
                if (agent.IsAlive)
                {
                    //Creates default Rmpty Precept.
                    TAgentPrecept precept = new TAgentPrecept();
                    //Vreates default NoOperation Action.
                    TAgentAction anAction = new TAgentAction();

                    var preceptTask = Task.Run(() =>
                    {
                        // Were we already canceled?
                        cancellationToken.ThrowIfCancellationRequested();

                        return agent.PollAgentSensorsAsync(EnvironmentObjects);
                    }, cancellationToken);



                    precept = await preceptTask;
                    //    .ContinueWith(async preceptResult =>
                    //{
                    //    if (currentCancellationToken.IsCancellationRequested)
                    //    {
                    //        // Were we already canceled?
                    //        currentCancellationToken.ThrowIfCancellationRequested();
                    //    }

                    //    return await agent.ProcessAgentFunction(preceptResult.Result);
                    //}, currentCancellationToken).Unwrap();

                    if (!cancellationToken.IsCancellationRequested && preceptTask.IsCompletedSuccessfully)
                    {
                        var actionTask = Task.Run(() =>
                        {
                            // Were we already canceled?
                            cancellationToken.ThrowIfCancellationRequested();

                            return agent.ProcessAgentFunction(precept);
                        }, cancellationToken);

                        anAction = await actionTask;

                        if (!cancellationToken.IsCancellationRequested && actionTask.IsCompletedSuccessfully)
                        {
                            if (anAction.ActionName.Equals(AgentComponentDefaults.ACTION_NO_OPERATION))
                            {
                                agent.ExecuteNoOp();
                            }
                            else
                            {
                                agent.IsAlive = true;
                                agent.ProcessAgentAcuators(anAction, EnvironmentObjects);
                            }
                            OnAgentActed(new EnviromentAgentActedEventArgs<TAgent, TAgentPrecept, TAgentAction>(agent, precept, anAction, this));
                        }
                        else
                        {
                            cancellationToken.ThrowIfCancellationRequested();

                            if (actionTask.IsFaulted)
                            {
                                throw actionTask.Exception;
                            }
                        }
                    }
                    else
                    {
                        agent.OnAgentMessageNotification(new AgentNotificationEventArgs<TAgentPrecept, TAgentAction>(agent, "Error Processing the precept for the agent."));
                    }
                }
            }
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="amountStepsToMoveForward"><inheritdoc/></param>
        /// <param name="cancellationToken"><inheritdoc/></param>
        /// <returns></returns>
        public async Task StepAsync(int amountStepsToMoveForward, CancellationToken cancellationToken)
        {
            for (int i = 0; i < amountStepsToMoveForward; i++)
            {
                if (!cancellationToken.IsCancellationRequested)
                {
                    await Task.Delay(500, cancellationToken);
                    await StepAsync(cancellationToken);
                }
            }
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="cancellationToken"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public async Task StepUntilDoneAsync(CancellationToken cancellationToken)
        {
            while (!IsDone())
            {
                if (!cancellationToken.IsCancellationRequested)
                {
                    await StepAsync(cancellationToken);
                    var delayTask = Task.Delay(2000, cancellationToken);
                    await delayTask;

                    cancellationToken.ThrowIfCancellationRequested();
                }
            }
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public abstract void CreateExogenousChange();


        #endregion

    }
}
