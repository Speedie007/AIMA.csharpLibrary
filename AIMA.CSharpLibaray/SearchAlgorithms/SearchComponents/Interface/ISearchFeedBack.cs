using AIMA.CSharpLibrary.AgentComponents.Agent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Interface
{
    
    public partial  interface ISearchFeedBack<TState, TAction>
        where TAction : BaseAgentAction where TState : BaseAgentState
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Returns all the SearchMetrics of the search.</returns>
        SearchMetrics GetMetrics();

        /// <summary>
        /// Adds A listener to the list of node listeners. It is informed whenever A node is expanded during search.
        /// </summary>
        /// <param name="listener"></param>
        void AddNodeListener(Action<Node<TState, TAction>> listener);

        /// <summary>
        ///  Removes A listener from the list of node listeners.
        /// </summary>
        /// <param name="listener"></param>
        /// <returns></returns>
        bool removeNodeListener(Action<Node<TState, TAction>> listener);
    }
}
