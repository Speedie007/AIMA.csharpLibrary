using aima.core.util;
using AIMA.csharpLibrary.Agent.AgentComponents;
using AIMA.csharpLibrary.Agent.AgentComponents.Base;
using AIMA.csharpLibrary.Agent.EnviromentComponents.EventsArguments;
using AIMA.csharpLibrary.Agent.EnviromentComponents.Interface;
using AIMA.csharpLibrary.AgentProgram.Agent.Interface;

namespace AIMA.csharpLibrary.Agent.EnviromentComponents.Base
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
        IEnvironment<TAgent, TPrecept, TAction>,
        IEnviromentEventFeedBack<TAgent, TPrecept, TAction>,
        IDisposable
                where TAction : AgentAction
                where TPrecept : AgentPrecept
                where TAgent : BaseAgent<TPrecept, TAction> 
    {

        /// <summary>
        /// Note: Use LinkedHashSet's in order to ensure order is respected.
        /// Custom implementation is used within this libaray as C# does not Have a native LinkedHashSet as in the java libaray .
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


        #region Cstor
        /// <summary>
        /// Base Constructor for construction of the components of the required Enviroment domain.
        ///<para>Initializes a container => (Agents) which houses all the relevant agents that will operate with this enviroment.</para>
        ///<para>Initializes a container => (EnviromantObjects) which houses all the relevant objects that will found and operated apon within this enviroment.</para>
        /// </summary>
        public BaseEnvironment()
        {
            Agents = new LinkedHashSet<TAgent>();
            EnvironmentObjects = new LinkedHashSet<IEnvironmentObject>();
            PerformanceMeasures = new Dictionary<TAgent, double>();
            AgentAddedEventHandler = OnAgentAdded;
            AgentRemovedEventHandler = OnAgentRemoved;
            AgentActedEventHandler = OnAgentActed;
        }

        #region Utility Methods
        private void BindEventHandlers()
        {

        }
        #endregion

        #region Events Handlers
        /// <summary>
        /// Will raise the OnAgentAdded Event to Notify the caller of the agent that was added to the enviroment.
        /// </summary>
        private delegate void AgentAddedDelegate(EnviromentAgentAddedEventArgs<TAgent, TPrecept, TAction> args);
        private AgentAddedDelegate AgentAddedEventHandler { get; }
        /// <summary>
        /// Will raise the OnAgentRemoved Event to Notify the caller of the agent that was removed to the enviroment.
        /// </summary>
        private delegate void AgentRemovedDelegate(EnviromentAgentRemovedEventArgs<TAgent, TPrecept, TAction> args);
        private AgentRemovedDelegate AgentRemovedEventHandler { get; }
        /// <summary>
        /// Will raise the OnAgentActed Event to Notify the caller of the agent that performed an action within the enviroment.
        /// </summary>
        public delegate void AgentActedDelegate(EnviromentAgentActedEventArgs<TAgent, TPrecept, TAction> args);
        private AgentActedDelegate AgentActedEventHandler { get; }
        /// <summary>
        /// The event-invoking method that derived classes can override to process logic when an agent is added.
        /// </summary>
        /// <param name="args"></param>
        public virtual void OnAgentAdded(EnviromentAgentAddedEventArgs<TAgent, TPrecept, TAction> args)
        { AgentAddedEventHandler?.Invoke(args); }
        /// <summary>
        /// The event-invoking method that derived classes can override to process logic when an agent is removed.
        /// </summary>
        /// <param name="args"></param>
        public virtual void OnAgentRemoved(EnviromentAgentRemovedEventArgs<TAgent, TPrecept, TAction> args)
        { AgentRemovedEventHandler?.Invoke(args); }
        /// <summary>
        /// The event-invoking method that derived classes can override to process logic when an agent has performed an action.
        /// </summary>
        /// <param name="args"></param>
        public virtual void OnAgentActed(EnviromentAgentActedEventArgs<TAgent, TPrecept, TAction> args)
        { AgentActedEventHandler?.Invoke(args); }
        #endregion

        #endregion
        /// <summary>
        /// Adds the Agent to the enviroment into the enviroment objects collection.
        /// </summary>
        /// <param name="agent">The Agent To be added into the enviroment.</param>
        public void AddAgent(TAgent agent)
        {
            Agents.Add(agent);
            AddEnvironmentObject(agent);
            OnAgentAdded(new EnviromentAgentAddedEventArgs<TAgent, TPrecept, TAction>(
                agent,
                (BaseEnvironment<TAgent, TPrecept, TAction>)this));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="environmentObject"></param>
        public void AddEnvironmentObject(IEnvironmentObject environmentObject)
        {
            EnvironmentObjects.Add(environmentObject);
        }

        /// <summary>
        /// Retrieve a list of all the agents currently operating within this given enviroment.
        /// </summary>
        /// <returns>// Return as a List but also ensure the caller cannot modify</returns>
        public List<TAgent> GetAgents()
        {
            return new List<TAgent>(Agents);
        }
        /// <summary>
        /// Retrieve a list of all the enviromential objects currently "Living" within this given enviroment.
        /// </summary>
        /// <returns></returns>
        public List<IEnvironmentObject> GetEnvironmentObjects()
        {
            // Return as a List but also ensure the caller cannot modify
            return new List<IEnvironmentObject>(EnvironmentObjects);
        }

        public double GetPerformanceMeasure(TAgent agent)
        {
            if (PerformanceMeasures.TryGetValue(agent, out double measure))
                return measure;
            else
                return 0.0;
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
       
        public void RemoveAgent(TAgent agent)
        {
            //TODO: once the agents are operating on their own threads first check to verify if the agent is busy.
            //If so first cancel the current operation and then remove.
            Agents.Remove(agent);
            RemoveEnvironmentObject(agent);
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
                    TPrecept percept = GetPerceptSeenBy(agent);
                    TAction? anAction = agent.ActOnPrecept(percept);
                    if (anAction != null)
                    {
                        Execute(agent, anAction);
                        //notify(agent, percept, anAction.get());
                    }
                    else
                    {
                        ExecuteNoOp(agent);
                    }
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


        public void Dispose()
        {
             
        }

        public abstract void CreateExogenousChange();

        public abstract void ExecuteNoOp(TAgent agent);

        public  abstract void Execute(TAgent agent, TAction action);

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
    }
}
