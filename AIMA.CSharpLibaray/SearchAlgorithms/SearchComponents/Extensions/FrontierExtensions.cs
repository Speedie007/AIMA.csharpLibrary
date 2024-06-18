using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.State;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Base;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TElement"></typeparam>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public static class FrontierExtensions<TElement,TState,TAction>
        where TAction : BaseAction
        where TState : BaseAgentState
        where TElement : Node<TState,TAction> 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static BaseFrontierQueue<TElement> CreateLIFOQueue()
        {
            FrontierLIFOQueue<TElement> queue = new();

            return queue;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BaseFrontierQueue<TElement> CreateFIFOFrontier()
        {
            FontierFIFOQueue<TElement> queue = new();

            return queue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static BaseFrontierQueue<TElement> CreatePriorityQueueFrontier()
        {
            FrontiertPriorirtyQueue<TElement> queue = new();

            return queue;
        }
        
    }
    
}
