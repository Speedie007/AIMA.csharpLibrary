using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentComponents.Agent.Extentsions;
using AIMA.CSharpLibrary.AgentComponents.AgentProgramComponents.Interface;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgramComponents.Base
{
    /// <summary>
    /// Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 23 May 2024 - Date Last Updated: 23 May 2024</para>
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public abstract partial class BaseAgentProgram<TPrecept, TAction> : IAgentProgram<TPrecept, TAction>
        where TAction : BaseAgentAction
        where TPrecept : AgentPrecept
    {


        public Func<TPrecept, TAction> PreceptToActionFunc { get; }

        protected BaseAgentProgram()
        {
            PreceptToActionFunc = ProcessRecievedPrecept;
        }

        /// <summary>
        /// <para>Function TABLE-DRIVEN-AGENT(percept) returns an action</para>
        /// </summary>
        /// <param name="percept"></param>
        /// <returns></returns>
        public abstract TAction ProcessRecievedPrecept(TPrecept percept);
        //{
        //    return (TAction)ActionExtentions.GetNoOperationAction();
        //}

        public abstract void Initialize();

    }
}
