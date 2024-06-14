using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Base;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Extensions
{
    public static class FrontierExtensions<TElement,TState,TAction>
        where TAction : BaseAgentAction
        where TState : BaseAgentState
        where TElement : Node<TState,TAction> 
    {
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

        public static BaseFrontierQueue<TElement> CreatePriorityQueueFrontier()
        {
            FrontiertPriorirtyQueue<TElement> queue = new();

            return queue;
        }
        
    }
    
}
