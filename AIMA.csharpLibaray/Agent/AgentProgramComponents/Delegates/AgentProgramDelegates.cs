using AIMA.csharpLibrary.AgentProgram.Agent.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMA.csharpLibrary.Agent.AgentProgramComponents.Delegates
{
    /// <summary>
    /// Delegates Used To reference the Agent Program Methods/Functions
    ///<para>
    ///Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 10 May 2024 - Date Last Updated: 11 May 2024</para>
    /// </summary>
    /// <typeparam name="TPrecept">Type which is used to represent percepts</typeparam>
    /// <typeparam name="TAction">Type which is used to represent actions</typeparam>
    public class AgentProgramDelegates<TAction,TPrecept>
    {
        /// <summary>
        /// Processes the relevant logic accosiated with the assigned Apply methods defined in the Concrete Agent Program Instantance.
        /// </summary>
        /// <param name="percept">Precept precieved by the agent program</param>
        /// <returns></returns>
        public delegate TAction? ApplyPrecept(TPrecept percept);
    }
}
