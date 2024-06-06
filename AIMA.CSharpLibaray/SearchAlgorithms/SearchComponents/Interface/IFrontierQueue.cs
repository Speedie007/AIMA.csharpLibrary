namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Interface
{
    public interface IFrontierQueue<TElement>
    {
        void Clear();
        bool Contains(TElement node);
        TElement Dequeue();
        void Enqueue(TElement node, double priority = 0);
        TElement Peek();
        int Size();
        bool IsEmpty();
    }
}