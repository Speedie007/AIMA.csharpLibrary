using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.State;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Base;
using System.Xml.Linq;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Extensions
{
    //BaseFrontierQueue<Node<TState, TAction>>
    /// <summary>
    /// 
    /// </summary>
    public static class FrontierExtensionsV1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <typeparam name="TAction"></typeparam>
        /// <returns></returns>
        public static BaseFrontierQueue<Node<TState, TAction>> CreateLIFOQueue<TState, TAction>()
            where TAction : BaseAction, new()
            where TState : BaseAgentState, new()
        {
            FrontierLIFOQueue<Node<TState, TAction>> queue = new();

            return queue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <typeparam name="TAction"></typeparam>
        /// <returns></returns>
        public static BaseFrontierQueue<Node<TState, TAction>> CreateFIFOFrontier<TState, TAction>()
            where TAction : BaseAction, new()
            where TState : BaseAgentState, new()
        {
            FontierFIFOQueue<Node<TState, TAction>> queue = new();

            return queue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <typeparam name="TAction"></typeparam>
        /// <returns></returns>
        public static BaseFrontierQueue<Node<TState, TAction>> CreatePriorityQueueFrontier<TState, TAction>()
            where TAction : BaseAction, new()
            where TState : BaseAgentState, new()
        {
            FrontiertPriorirtyQueue<Node<TState, TAction>> queue = new();

            return queue;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TElement"></typeparam>
    /// <typeparam name="TState"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public static class FrontierExtensions<TElement, TState, TAction>
        where TAction : BaseAction, new()
        where TState : BaseAgentState, new()
        where TElement : Node<TState, TAction>, new()
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
