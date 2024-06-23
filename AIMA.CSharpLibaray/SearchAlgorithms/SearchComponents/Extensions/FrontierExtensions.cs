using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.State.Base;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Base;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Extensions
{
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
            where TState : BaseState, new()
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
            where TState : BaseState, new()
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
            where TState : BaseState, new()
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
        where TState : BaseState, new()
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
