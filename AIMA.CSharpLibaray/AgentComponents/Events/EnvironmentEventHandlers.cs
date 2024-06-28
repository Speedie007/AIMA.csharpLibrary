using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Environment;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events
{
    /// <summary>
    ///<para>Defines the required event Handlers for the Agent Environment</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 9 June 2024 - Date Last Updated: 16 June 2024</para>
    /// </summary>
    public static class EnvironmentEventHandlers
    {
        /// <summary>
        /// 
        /// </summary>
        
        /// <typeparam name="TAgent"></typeparam>
        /// <typeparam name="TPrecept"></typeparam>
        /// <typeparam name="TAction"></typeparam>
        /// <param name="AgentAddedEventArgs"></param>
        public delegate void AgentAddedEventHandler< TAgent, TPrecept, TAction>(EnvironmentAgentAddedEventArgs< TAgent, TPrecept, TAction> AgentAddedEventArgs)
             where TAction : BaseAction, new()
            where TPrecept : BasePrecept, new()
              
            where TAgent : BaseAgent< TPrecept, TAction>, new();
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TAgent"></typeparam>
        /// <typeparam name="TPrecept"></typeparam>
        /// <typeparam name="TAction"></typeparam>
        /// <param name="AgentRemovedArgs"></param>
        
        public delegate void AgentRemovedEventHandler< TAgent, TPrecept, TAction>(EnvironmentAgentRemovedEventArgs< TAgent, TPrecept, TAction> AgentRemovedArgs)
             where TAction : BaseAction, new()
            where TPrecept : BasePrecept, new()
              
            where TAgent : BaseAgent< TPrecept, TAction>, new();
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TAgent"></typeparam>
        /// <typeparam name="TPrecept"></typeparam>
        /// <typeparam name="TAction"></typeparam>
        /// <param name="AgentActedEventArgs"></param>
        
        public delegate void AgentActedEventHandler< TAgent, TPrecept, TAction>(EnvironmentAgentActedEventArgs< TAgent, TPrecept, TAction> AgentActedEventArgs)
                where TAction : BaseAction, new()
                where TPrecept : BasePrecept, new()
                  
                where TAgent : BaseAgent< TPrecept, TAction>, new();
    }
}
