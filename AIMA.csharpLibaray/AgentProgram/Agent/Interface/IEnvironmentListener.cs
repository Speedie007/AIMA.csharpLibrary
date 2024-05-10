namespace AIMA.csharpLibrary.AgentProgram.Agent.Interface
{
    /// <summary>
    /// Allows applications to analyze and visualize the interaction of Agent(s) with an Environment.
    /// </summary>
    ///<para>
    ///Author:Ravi Mohan
    ///</para>
    ///<para>
    ///Author:Ciaran O'Reilly
    ///</para>
    ///<para>
    ///Author:Mike Stampone
    ///</para>
    ///<para>
    ///Author:Ruediger Lunde
    ///</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 10 May 2024 - Date Last Updated: 10 May 2024</para>
    /// <typeparam name="TPrecept">Type which is used to represent percepts</typeparam>
    /// <typeparam name="TAction">ype which is used to represent actions</typeparam>
    public partial interface IEnvironmentListener<TPrecept, TAction> 
        where TPrecept: class 
        where TAction : class
    {
    }
}