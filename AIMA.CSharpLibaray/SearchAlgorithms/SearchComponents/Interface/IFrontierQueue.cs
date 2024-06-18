namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Interface
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TElement"></typeparam>
    public interface IFrontierQueue<TElement>
    {
        /// <summary>
        /// 
        /// </summary>
        void Clear();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        bool Contains(TElement node);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        TElement? Dequeue();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="priority"></param>
        void Enqueue(TElement node, double priority = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        TElement? Peek();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int Size();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();
    }
}