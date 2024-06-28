namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Problem.Interfaces
{
    /// <summary>
    /// <para>Artificial Intelligence A Modern Approach (3rd Edition): page 68.</para>
    /// <para>The step cost of taking action A in state s to reach state s' is denoted by c(s, A, s').</para>
    ///<para>Author:Ruediger Lunde
    ///</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 17 May 2024 - Date Last Updated: 17 May 2024</para>
    /// </summary>
    /// <typeparam name="TState">The type used to represent states</typeparam>
    /// <typeparam name="TAction">The type of the actions to be used to navigate through the state space</typeparam>
    public partial interface IStepCostFunction<TState, TAction>
    {
        //public delegate T ApplyAsT(TState s, TAgentAction A, TState sDelta);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="a"></param>
        /// <param name="sDelta"></param>
        /// <returns></returns>
        public double ApplyAsT(TState s, TAction a, TState sDelta)
        {
            return 1;
        }
        //Func<TState, TAgentAction, TState> ApplyAsT();
    }



}
