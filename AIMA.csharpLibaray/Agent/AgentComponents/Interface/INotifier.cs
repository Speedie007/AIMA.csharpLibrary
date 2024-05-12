namespace AIMA.csharpLibrary.Agent.AgentComponents.Interface
{
    /// <summary>
    ///<para>
    ///Author:Ciaran O'Reilly
    ///</para>
    ///<para>
    ///Author:Ruediger Lunde
    ///</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 11 May 2024 - Date Last Updated: 10 May 2024</para>
    /// </summary>
    public partial interface  INotifier
    {
        /// <summary>
        ///  A simple notification message, to be forwarded to someone.
        /// </summary>
        /// <param name="message">The message to be forwarded from the current Envirment.</param>
        void Notify(string message);
    }
}
