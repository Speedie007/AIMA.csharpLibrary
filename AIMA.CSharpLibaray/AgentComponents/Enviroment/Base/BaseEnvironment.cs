using AIMA.CSharpLibrary.AgentComponents.Actions;
using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.Events;
using AIMA.CSharpLibrary.AgentComponents.Enviroment.EventsArguments;
using AIMA.CSharpLibrary.AgentComponents.EnviromentComponents.Interface;
using AIMA.CSharpLibrary.AgentComponents.Precepts;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Enviroment.Base
{
    /// <summary>
    /// <para>Base(Abstract) Enviroment used to represent the domain within wich the agent operates.</para>
    ///<para>
    ///Author:Ravi Mohan
    ///</para>
    ///<para>
    ///Author:Ciaran O'Reilly
    ///</para>
    ///<para>
    ///Author:Ruediger Lunde
    ///</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 11 May 2024 - Date Last Updated: 11 May 2024</para>
    /// </summary>
    /// <typeparam name="TPrecept">Type which is used to represent percepts</typeparam>
    /// <typeparam name="TAction">Type which is used to represent actions</typeparam>
    public abstract partial class BaseEnvironment<TAgent, TPrecept, TAction> :
        IEnvironment<TAgent, TPrecept, TAction>

                where TAction : BaseAgentAction, new()
                where TPrecept : BaseAgentPrecept, new()
                where TAgent : BaseAgent<TPrecept, TAction>
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
        /// <summary>
        /// 
        /// </summary>
        protected Dictionary<TAgent, double> PerformanceMeasures { get; private set; }
        #endregion

        #region Cstor
        /// <summary>
        /// Base Constructor for construction of the components of the required Enviroment domain.
        ///<para>Initializes A container => (Agents) which houses all the relevant agents that will operate with this enviroment.</para>
        ///<para>Initializes A container => (EnviromantObjects) which houses all the relevant objects that will found and operated apon within this enviroment.</para>
        /// </summary>
        public BaseEnvironment()
        {
            Agents = new LinkedHashSet<TAgent>();
            EnvironmentObjects = new LinkedHashSet<IEnvironmentObject>();
            PerformanceMeasures = new Dictionary<TAgent, double>();
        }
        #endregion

        #region Events Handlers
        /// <summary>
        /// Will raise the OnAgentActed Event to Notify the caller of the agent that performed an action within the enviroment.
        /// </summary>
        public event EnviromentEventHandlers<TAgent, TPrecept, TAction>.AgentActedEventHandler? AgentActed;

        /// <summary>
        /// Will raise the OnAgentAdded Event to Notify the caller of the agent that was added to the enviroment.
        /// </summary>
        public event EnviromentEventHandlers<TAgent, TPrecept, TAction>.AgentAddedEventHandler? AgentAdded;

        /// <summary>
        /// Will raise the OnAgentRemoved Event to Notify the caller of the agent that was removed from the enviroment.
        /// </summary>
        public event EnviromentEventHandlers<TAgent, TPrecept, TAction>.AgentRemovedEventHandler? AgentRemoved;


        /// <summary>
        /// The event-invoking method that derived classes can override to process logic when an agent is added.
        /// </summary>
        /// <param name="args"></param>
        public virtual void OnAgentAdded(EnviromentAgentAddedEventArgs<TAgent, TPrecept, TAction> args)
        { AgentAdded?.Invoke(args); }
        /// <summary>
        /// The event-invoking method that derived classes can override to process logic when an agent is removed.
        /// </summary>
        /// <param name="args"></param>
        public virtual void OnAgentRemoved(EnviromentAgentRemovedEventArgs<TAgent, TPrecept, TAction> args)
        { AgentRemoved?.Invoke(args); }
        /// <summary>
        /// The event-invoking method that derived classes can override to process logic when an agent has performed an action.
        /// </summary>
        /// <param name="args"></param>
        public virtual void OnAgentActed(EnviromentAgentActedEventArgs<TAgent, TPrecept, TAction> args)
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
            PerformanceMeasures.Add(agent, 0);
            OnAgentAdded(new EnviromentAgentAddedEventArgs<TAgent, TPrecept, TAction>(agent, this));
        }
        /// <summary>
        /// Retrieve A list of all the agents currently operating within this given enviroment.
        /// </summary>
        /// <returns>// Return as A List but also ensure the caller cannot modify</returns>
        public List<TAgent> GetAgents()
        {
            return new List<TAgent>(Agents);
        }
        /// <summary>
        /// Getthe current performance measure of A selected agent.
        /// </summary>
        /// <param name="agent">Agent for which the performance measure is required.</param>
        /// <returns>Agent Performance measure as double</returns>
        public double GetAgentPerformanceMeasure(TAgent agent)
        {
            return PerformanceMeasures.TryGetValue(agent, out double measure) ? measure : 0;
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
            PerformanceMeasures.Remove(agent);
            OnAgentRemoved(new EnviromentAgentRemovedEventArgs<TAgent, TPrecept, TAction>(agent, this));
        }
        #endregion

        #region Enviroment Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="environmentObject"></param>
        public void AddEnvironmentObject(IEnvironmentObject environmentObject)
        {
            EnvironmentObjects.Add(environmentObject);
        }
        /// <summary>
        /// Retrieve A list of all the enviromential objects currently "Living" within this given enviroment.
        /// </summary>
        /// <returns></returns>
        public List<IEnvironmentObject> GetEnvironmentObjects()
        {
            // Return as A List but also ensure the caller cannot modify
            return new List<IEnvironmentObject>(EnvironmentObjects);
        }


        /// <summary>
        /// Check to see if there are any agents currently busy completing required tasks.
        /// </summary>
        /// <returns>Returns true if there are no agent alive, else False</returns>
        public bool IsDone()
        {
            return Agents.Any(x => !x.IsAlive);
        }

        public void Notify(string message)
        {
            throw new NotImplementedException();
        }
        public void RemoveEnvironmentObject(IEnvironmentObject environmentObject)
        {
            EnvironmentObjects.Remove(environmentObject);
        }
        public abstract TPrecept GetPerceptSeenBy(TAgent agent);
        public void Step()
        {
            foreach (TAgent agent in Agents)
            {
                if (agent.IsAlive)
                {
                    TPrecept precept=  agent.PollAgentSensors(EnvironmentObjects);
                   // TPrecept precept = GetPerceptSeenBy(agent);
                    TAction anAction = agent.ActOnPrecept(precept);
                    if (anAction is AgentNoOperationAction)
                    {
                        ExecuteNoOp(agent);
                    }
                    else
                    {
                        agent.IsAlive = true;
                        ExecuteAgentAction(agent, anAction);
                    }
                    OnAgentActed(new EnviromentAgentActedEventArgs<TAgent, TPrecept, TAction>(agent, precept, anAction, this));
                }
            }
            CreateExogenousChange();
        }
        public void Step(int amountStepsToMoveForward)
        {
            for (int i = 0; i < amountStepsToMoveForward; i++)
                Step();
        }
        public void StepUntilDone()
        {
            while (!IsDone())
                Step();
        }




        public abstract void CreateExogenousChange();

        public abstract void ExecuteNoOp(TAgent agent);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="action"></param>
        public abstract void ExecuteAgentAction(TAgent agent, TAction action);

        public virtual bool UpdatePerformanceMeasure(TAgent agent, double measureAmount)
        {
            if (PerformanceMeasures.ContainsKey(agent))
            {
                PerformanceMeasures[agent] += measureAmount;
                return true;
            }
            else
                return false;
        }
        #endregion

    }
}
