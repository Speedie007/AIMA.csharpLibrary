using aima.core.util;
using AIMA.csharpLibrary.Agent.AgentComponents.Base;
using AIMA.csharpLibrary.Agent.AgentComponents.Interface;
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
    /// <typeparam name="TPrecpt">Type which is used to represent percepts</typeparam>
    /// <typeparam name="TAction">Type which is used to represent actions</typeparam>
    public partial class BaseEnvironment<TPrecpt, TAction> : IEnvironment<TPrecpt, TAction>, INotifier
    {

        // Note: Use LinkedHashSet's in order to ensure order is respected.
        // Custom implementation is used within tthis libaray as C# does not Have a native LinkedHashSet as in the java libaray .
        protected LinkedHashSet<BaseAgent<TPrecpt, TAction>> agents = new LinkedHashSet<BaseAgent<TPrecpt, TAction>>();


        #region Cstor
        public BaseEnvironment()
        {
        }
        #endregion
        public void AddAgent(IAgent<TPrecpt, TAction> agent)
        {
            throw new NotImplementedException();
        }

        public void AddEnvironmentObject(IEnvironmentObject environmentObject)
        {
            throw new NotImplementedException();
        }

        public List<IAgent<TPrecpt, TAction>> GetAgents()
        {
            throw new NotImplementedException();
        }

        public List<IEnvironmentObject> GetEnvironmentObjects()
        {
            throw new NotImplementedException();
        }

        public double GetPerformanceMeasure(IAgent<TPrecpt, TAction> agent)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public void Notify(string message)
        {
            throw new NotImplementedException();
        }

        public void RemoveAgent(IAgent<TPrecpt, TAction> agent)
        {
            throw new NotImplementedException();
        }

        public void RemoveEnvironmentObject(IEnvironmentObject environmentObject)
        {
            throw new NotImplementedException();
        }

        public void Step()
        {
            throw new NotImplementedException();
        }

        public void Step(int amountStepsToMoveForward)
        {
            throw new NotImplementedException();
        }

        public void StepUntilDone()
        {
            throw new NotImplementedException();
        }
    }
}
