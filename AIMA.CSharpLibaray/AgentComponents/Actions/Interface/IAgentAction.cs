﻿using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Actions.Interface
{
    /// <summary>
    /// <para>Describes an ActionExecuted that can or has been taken by an BaseAgent via one of its Actuators.
    /// </para>
    /// <remarks> Serves as marker interface but the framework does not require to use it.</remarks>
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
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 11 May 2024 - Date Last Updated: 11 May 2024</para>
    /// </summary>
    public partial interface IAgentAction
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TPrecept"></typeparam>
        /// <typeparam name="TAction"></typeparam>
        
        /// <param name="environmentObjects"></param>
        /// <param name="agent"></param>
        void ExecuteAction<TPrecept, TAction>(LinkedDictionarySet<IEnvironmentObject> environmentObjects, BaseAgent< TPrecept, TAction> agent)
            where TPrecept : BasePrecept, new()
            where TAction : BaseAction, new()
              ;
    }
}
