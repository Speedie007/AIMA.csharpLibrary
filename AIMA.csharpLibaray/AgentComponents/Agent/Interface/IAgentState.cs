namespace AIMA.csharpLibrary.AgentComponents.Agent.Interface
{
    /// <summary>
    /// <para>Artificial Intelligence A Modern Approach(3rd Edition): pg 50.</para>
    /// <para>
    ///The most effective way to handle partial observability is for the agent to
    ///keep track of the part of the world it can't see now. That is, the agent
    ///should maintain some sort of internal state that depends on the percept
    ///history and thereby reflects at least some of the unobserved aspects of the
    ///current state.
    ///</para>
    ///<remarks>
    ///This implementation serves as marker interface but the framework does
    ///not require to use it.
    ///</remarks>
    ///<para>
    ///Author:Ciaran O'Reilly
    ///</para>
    ///<para>
    ///Author:Ruediger Lunde
    /// </para>
    ///<para>
    ///Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 10 May 2024 - Date Last Updated: 10 May 2024</para>
    /// </summary>
    public partial interface IAgentState
    {
    }
}
