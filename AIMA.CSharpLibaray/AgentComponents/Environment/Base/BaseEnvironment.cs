using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Common;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.AgentComponents.Events;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Agent;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Environment;
using AIMA.CSharpLibrary.AgentComponents.Events.Interface;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Environment.Base
{
    /// <summary>
    /// <para>Base(Base) Environment used to represent the domain within which the agent operates.</para>
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
    /// <typeparam name="TAgent">Type which represents the agent used in this Environment</typeparam>
    /// <typeparam name="TAgentPrecept">Type which is used to represent percepts</typeparam>
    /// <typeparam name="TAgentAction">Type which is used to represent actions</typeparam>
    
    public abstract partial class BaseEnvironment< TAgent, TAgentPrecept, TAgentAction> :
        IEnvironment< TAgent, TAgentPrecept, TAgentAction>,
        IEnvironmentEvents< TAgent, TAgentPrecept, TAgentAction>,
        IEnvironmentEventFeedBack< TAgent, TAgentPrecept, TAgentAction>
                where TAgentAction : BaseAction, new()
                where TAgentPrecept : BasePrecept, new()
                 
                where TAgent : BaseAgent< TAgentPrecept, TAgentAction>, new()

    {
        #region Properties
        /// <summary>
        /// Note: Use LinkedDictionarySet's in order to ensure order is respected.
        /// Custom implementation is used within this library as C# does not Have A native LinkedDictionarySet as in the java library.
        /// </summary>
        protected LinkedDictionarySet<TAgent> Agents { get; private set; }
        /// <summary>
        /// Stores all the relevant objects which for part of the domain in which the agent operates.
        /// </summary>
        protected LinkedDictionarySet<IEnvironmentObject> EnvironmentObjects { get; private set; }
        #endregion

        #region Cstor
        /// <summary>
        /// Base Constructor for construction of the components of the required Environment domain.
        /// <list type="bullet">
        /// <item>
        /// <description>Initializes A container => (Agents) which houses all the relevant agents that will operate with this Environment.</description>
        /// </item>
        /// <item>
        /// <description>Initializes A container => (EnvironmentObjects) which houses all the relevant objects that will found and operated upon within this Environment.</description>
        /// </item>
        /// </list>
        /// </summary>
        public BaseEnvironment()
        {
            Agents = new LinkedDictionarySet<TAgent>();
            EnvironmentObjects = new LinkedDictionarySet<IEnvironmentObject>();
        }
        #endregion

        #region Events Handlers
        /// <summary>
        /// Will raise the OnAgentActed Event to Notify the caller of the agent that performed an action within the Environment.
        /// </summary>
        public event EnvironmentEventHandlers.AgentActedEventHandler< TAgent, TAgentPrecept, TAgentAction>? AgentActedEvent;

        /// <summary>
        /// Will raise the OnAgentAdded Event to Notify the caller of the agent that was added to the Environment.
        /// </summary>
        public event EnvironmentEventHandlers.AgentAddedEventHandler< TAgent, TAgentPrecept, TAgentAction>? AgentAddedEvent;

        /// <summary>
        /// Will raise the OnAgentRemoved Event to Notify the caller of the agent that was removed from the Environment.
        /// </summary>
        public event EnvironmentEventHandlers.AgentRemovedEventHandler< TAgent, TAgentPrecept, TAgentAction>? AgentRemovedEvent;

        /// <summary>
        /// The event-invoking method that derived classes can override to process logic when an agent is added.
        /// </summary>
        /// <param name="args"></param>
        public virtual void OnAgentAdded(EnvironmentAgentAddedEventArgs< TAgent, TAgentPrecept, TAgentAction> args)
        { AgentAddedEvent?.Invoke(args); }
        /// <summary>
        /// The event-invoking method that derived classes can override to process logic when an agent is removed.
        /// </summary>
        /// <param name="args"></param>
        public virtual void OnAgentRemoved(EnvironmentAgentRemovedEventArgs< TAgent, TAgentPrecept, TAgentAction> args)
        { AgentRemovedEvent?.Invoke(args); }
        /// <summary>
        /// The event-invoking method that derived classes can override to process logic when an agent has performed an action.
        /// </summary>
        /// <param name="args"></param>
        public virtual void OnAgentActed(EnvironmentAgentActedEventArgs< TAgent, TAgentPrecept, TAgentAction> args)
        { AgentActedEvent?.Invoke(args); }
        #endregion

        #region Agent Methods
        /// <summary>
        /// Adds the Agent to the Environment into the Environment objects collection.
        /// </summary>
        /// <param name="agent">The Agent To be added into the Environment.</param>
        public void AddAgent(TAgent agent)
        {
            Agents.Add(agent);
            AddEnvironmentObject(agent);
            OnAgentAdded(new EnvironmentAgentAddedEventArgs< TAgent, TAgentPrecept, TAgentAction>(agent, this));
        }
        /// <summary>
        /// Retrieve A list of all the agents currently operating within this given Environment.
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
        /// Removes A selected agent from the Environment.
        /// </summary>
        /// <param name="agent">Agent To be removed.</param>
        public void RemoveAgent(TAgent agent)
        {
            //TODO: once the agents are operating on their own threads first check to verify if the agent is busy.
            //If so first cancel the current operation and then remove.
            Agents.Remove(agent);
            RemoveEnvironmentObject(agent);
            OnAgentRemoved(new EnvironmentAgentRemovedEventArgs< TAgent, TAgentPrecept, TAgentAction>(agent, this));
        }
        #endregion

        #region Environment Methods
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
        public async Task StepAsync(CancellationToken cancellationToken)
        {
            foreach (TAgent agent in Agents)
            {
                if (agent.IsAlive)
                {
                    //Creates default Empty Precept.
                    TAgentPrecept precept = new();
                    //Creates default NoOperation Action.
                    TAgentAction anAction = new();

                    var preceptTask = Task.Run(() =>
                    {
                        // Were we already canceled?
                        cancellationToken.ThrowIfCancellationRequested();

                        return agent.ProcessAgentSensors(EnvironmentObjects);
                    }, cancellationToken);
                    //TODO: Chain the functions together.
                    anAction = await preceptTask

                        .ContinueWith(
                        (preceptResult) =>
                        {
                            if (cancellationToken.IsCancellationRequested)
                                // Were we already canceled?
                                cancellationToken.ThrowIfCancellationRequested();

                            return agent.ProcessAgentFunction(preceptResult.Result);
                        }, cancellationToken);//.Unwrap();

                    //var actionTask = Task.Run(() =>
                    //{
                    //    // Were we already canceled?
                    //    cancellationToken.ThrowIfCancellationRequested();

                    //    return agent.ProcessAgentFunction(precept);
                    //}, cancellationToken);

                    //anAction = await actionTask;


                    if (!cancellationToken.IsCancellationRequested && preceptTask.IsCompletedSuccessfully)
                    {
                        if (anAction.ActionName.Equals(AgentComponentDefaults.ACTION_NO_OPERATION))
                        {
                            agent.ExecuteNoOp();
                        }
                        else
                        {
                            agent.IsAlive = true;
                            agent.ProcessAgentActuators(anAction, EnvironmentObjects);
                        }
                        OnAgentActed(new EnvironmentAgentActedEventArgs< TAgent, TAgentPrecept, TAgentAction>(agent, precept, anAction, this));
                    }
                    else
                    {
                        if (preceptTask.IsFaulted)
                        {
                            agent.OnAgentMessageNotification(new AgentNotificationEventArgs< TAgentPrecept, TAgentAction>(agent, "Error Processing the precept for the agent."));
                            throw preceptTask.Exception;
                        }
                        cancellationToken.ThrowIfCancellationRequested();
                    }
                    CreateExogenousChange();
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
                    //await Task.Delay(50, cancellationToken);
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
                    var delayTask = Task.Delay(250, cancellationToken);
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
