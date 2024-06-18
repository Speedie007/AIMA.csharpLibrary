using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Interface;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Base
{
    /// <summary>
    /// Represents A last-in, first-out (LIFO) collection of instances of the same specified type.
    /// Represents A first-in, first-out (FIFO) collection of instances of the same specified type.
    /// </summary>
    /// <typeparam name="TElement"></typeparam>
    public abstract class BaseFrontierQueue<TElement> : IFrontierQueue<TElement>
    {
        /// <summary>
        /// 
        /// </summary>
        protected BaseFrontierQueue() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public abstract bool Contains(TElement node);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract TElement Dequeue();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract TElement Peek();
        /// <summary>
        /// 
        /// </summary>
        public abstract void Clear();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="priority"></param>
        public abstract void Enqueue(TElement node, double priority = 1);

        /// <summary>
        /// Size of the collection.
        /// </summary>
        /// <returns>The number of elements in this collection.</returns>
        public abstract int Size();
        /// <summary>
        /// 
        /// </summary>
        /// <returns>true, if there are no items in the collection, else false.</returns>
        public abstract bool IsEmpty();
    }
}
