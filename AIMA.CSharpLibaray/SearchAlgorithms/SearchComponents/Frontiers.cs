using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents.Base;

namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents
{
    #region Priority Queue with PriorityQueue<T,P> Backing
    /// <summary>
    /// <para>Represents A collection of items that have A value and A priority. </para>
    /// <para>On dequeue, the item with the lowest priority value is removed.</para>
    /// <remarks>
    /// Implements an array-backed, quaternary min-heap. 
    /// Each element is enqueued with an associated priority that determines the dequeue order. 
    /// Elements with the lowest priority are dequeued first. 
    /// Note: that the type does not guarantee first-in-first-out semantics for elements of equal priority.
    /// </remarks>
    /// <para>
    /// Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    /// </para>
    /// <para>
    /// Date Created: 17 May 2024 - Date Last Updated: 18 May 2024
    /// </para>
    /// </summary>
    /// <typeparam name="TElement">Specifies the type of elements in the queue.</typeparam>
    public partial class FrontiertPriorirtyQueue<TElement> : BaseFrontierQueue<TElement>
        where TElement : class, new()
    {
        #region Properties
        private readonly IComparer<TElement> _keyComparer;
        /// <summary>
        /// Additional Resources:
        /// https://www.bytehide.com/blog/priority-queque-csharp
        /// </summary>
        public PriorityQueue<TElement, double> PriorityQueue { get; private set; }
        #endregion
        #region Cstor
        /// <summary>
        ///Initializes A new instance of the PriorityQueue<![CDATA[<TElement>,double]]> class.
        /// </summary>
        /// <param name="comparer">Custom comparer dictating the ordering of elements. Uses Default if the argument is null.</param>
        public FrontiertPriorirtyQueue(IComparer<TElement>? comparer = null)
        {
            _keyComparer = comparer ?? Comparer<TElement>.Default;
            PriorityQueue = new PriorityQueue<TElement, double>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// This method is not implement for the prioity Queue
        /// <remarks>Use Peek method to view the first piroitized items in the queue.</remarks>
        /// </summary>
        /// <param name="node"></param>
        /// <returns>A NotImplementedException</returns>
        /// <exception cref="NotImplementedException"></exception>
        public override bool Contains(TElement node)
        {
            return PriorityQueue.UnorderedItems.Any(x => x.Element == node);
            //throw new NotImplementedException();
        }
        /// <summary>
        /// Removes and returns the minimal element from the PriorityQueue<![CDATA[<TElement>,double]]> - that is, the element with the lowest priority value(Default).
        /// </summary>
        /// <returns>The minimal element of the PriorityQueue<![CDATA[<TElement>,double]]>-Default.
        /// <para>Can change this to return the maximum by implementing A custom comparer in the constuctor when creating the queue.</para></returns>
        public override TElement Dequeue()
        {
            var result = PriorityQueue.TryDequeue(out TElement? node, out double priority) ? node : new();
            PriorityQueue.TrimExcess();
            return result;
        }

        /// <summary>
        /// <para>Returns A value that indicates whether there is A minimal element in the PriorityQueue<![CDATA[<TElement>,double]]>, and if one is present, copies it and its associated priority to the element and priority arguments.</para>
        /// <remarks>The element is not removed from the PriorityQueue<![CDATA[<TElement>,double]]>.</remarks>
        /// </summary>
        /// <returns>Returns the minimal element from the PriorityQueue<![CDATA[<TElement>,double]]> without removing it.</returns>
        public override TElement Peek()
        {
            return PriorityQueue.TryPeek(out TElement? node, out double cost) ? node : new();
        }
        /// <summary>
        /// Removes all items from the PriorityQueue<![CDATA[<TElement>,double]]>.
        /// </summary>
        public override void Clear()
        {
            PriorityQueue.Clear();
        }
        /// <summary>
        /// Adds the specified element with associated priority to the PriorityQueue<![CDATA[<TElement>,double]]>.
        /// </summary>
        /// <param name="node">The element to add to the PriorityQueue<![CDATA[<TElement>,double]]>.</param>
        /// <param name="priority">The priority with which to associate the new element.</param>
        public override void Enqueue(TElement node, double priority)
        {
            PriorityQueue.Enqueue(node, priority);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int Size()
        {
            return PriorityQueue.Count;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override bool IsEmpty()
        {
            return PriorityQueue.Count == 0;
        }
        #endregion

    }

    #endregion

    #region LIFO Queue with Stack Backing
    /// <summary>
    /// Represents A variable size last-in-first-out (LIFO) collection of instances of the same specified type.
    ///<para>
    ///Author:Ruediger Lunde
    ///</para>
    ///<para>
    ///Author:Ravi Mohan
    ///</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 17 May 2024 - Date Last Updated: 18 May 2024</para>
    /// </summary>
    /// <typeparam name="TElement">Specifies the type of elements in the stack.</typeparam>
    public partial class FrontierLIFOQueue<TElement> : BaseFrontierQueue<TElement>
        where TElement : class, new()
    {
        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public Stack<TElement> Stack { get; private set; }
        #endregion

        #region Cstor
        /// <summary>
        /// Initializes A new instance of the Stack<![CDATA[<TElement>]]> class that is empty and has the default initial capacity.
        /// </summary>
        public FrontierLIFOQueue()
        {
            Stack = new Stack<TElement>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Determines whether an element is in the Stack<![CDATA[<TElement>]]>.
        /// </summary>
        /// <param name="node">The object to locate in the Stack<![CDATA[<TElement>]]>. The value can be null for reference types.</param>
        /// <returns>true if item is found in the Stack<![CDATA[<TElement>]]>; otherwise, false.</returns>
        public override bool Contains(TElement node)
        {
            return Stack.Contains(node);
        }
        /// <summary>
        /// Removes and returns the object at the top of the Stack<![CDATA[<TElement>]]>.
        /// </summary>
        /// <returns>The object removed from the top of the Stack<![CDATA[<TElement>]]>.</returns>
        public override TElement Dequeue()
        {
            return Stack.TryPop(out TElement? result) ? result : new();
        }

        /// <summary>
        /// <para>Returns A value that indicates whether there is an object at the top of the Stack<![CDATA[<TElement>]]>, and if one is present, copies it to the result parameter. </para>
        /// <para>The object is not removed from the Stack<![CDATA[<TElement>]]>.</para>
        /// </summary>
        /// <returns>If present, the object at the top of the Stack<![CDATA[<TElement>]]>; otherwise, the default value of <![CDATA[<TElement>]]>.</returns>
        public override TElement Peek()
        {
            return Stack.TryPeek(out TElement? result) ? result : default!;
        }
        /// <summary>
        /// Removes all objects from the Stack<![CDATA[<TElement>]]>.
        /// </summary>
        public override void Clear()
        {
            Stack.Clear();
        }

        /// <summary>
        /// <para>Inserts an object at the top of the Stack. </para>
        /// <remarks>
        /// In this context the priority is ignored and only the node is enqueued into the stack.
        /// </remarks>
        /// </summary>
        /// <param name="node">The object to push onto the Stack. The value can be null for reference types.</param>
        /// <param name="priority"></param>
        public override void Enqueue(TElement node, double priority)
        {
            Stack.Push(node);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int Size()
        {
            return Stack.Count;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override bool IsEmpty()
        {
            return Stack.Count == 0;
        }
        #endregion

    }
    #endregion

    #region FIFO Queue with Queue Backing
    /// <summary>
    /// Represents A first-in, first-out collection of objects. of instances of the same specified type.
    ///<para>
    ///Author:Ruediger Lunde
    ///</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 17 May 2024 - Date Last Updated: 18 May 2024</para>
    /// </summary>
    /// <typeparam name="TElement">Specifies the type of elements in the queue.</typeparam>
    public partial class FontierFIFOQueue<TElement> : BaseFrontierQueue<TElement>
        where TElement : class, new()
    {
        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public Queue<TElement> Queue { get; private set; }
        #endregion

        #region Cstor
        /// <summary>
        /// Initializes A new instance of the Queue<![CDATA[<TElement>]]> class.
        /// </summary>
        public FontierFIFOQueue()
        {
            Queue = new Queue<TElement>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Removes all objects from the Queue<![CDATA[<TElement>]]>.
        /// </summary>
        public override void Clear()
        {
            Queue.Clear();
        }
        /// <summary>
        /// Determines whether an element is in the Queue<![CDATA[<TElement>]]>.
        /// </summary>
        /// <param name="node">The object to locate in the Queue<![CDATA[<TElement>]]>. The value can be null for reference types.</param>
        /// <returns>true if item is found in the Queue<![CDATA[<TElement>]]>; otherwise, false.</returns>
        public override bool Contains(TElement node)
        {
            return Queue.Contains(node);
        }
        /// <summary>
        /// Removes and returns the object at the beginning of the Queue<![CDATA[<TElement>]]>.
        /// </summary>
        /// <returns>The object that is removed from the beginning of the Queue<![CDATA[<TElement>]]>.The object that is removed from the beginning of the Queue<![CDATA[<TElement>]]>.</returns>
        public override TElement Dequeue()
        {
            return Queue.TryDequeue(out TElement? result) ? result : new();
        }

        /// <summary>
        /// Returns A value that indicates whether there is an object at the beginning of the Queue<![CDATA[<TElement>]]>, and if one is present, copies it to the result parameter. 
        /// <para>The object is not removed from the Queue<![CDATA[<TElement>]]>.</para>
        /// </summary>
        /// <returns>If present, the object at the beginning of the Queue<![CDATA[<TElement>]]>; otherwise, the default value of T.</returns>
        public override TElement Peek()
        {
            return Queue.TryPeek(out TElement? result) ? result : new();
        }

        /// <summary>
        /// <para>TAdds an object to the end of the Queue<![CDATA[<TElement>]]>. </para>
        /// <para>The value can be null for reference types.</para>
        /// <remarks>
        /// In this context the priority is ignored and only the node is enqueued into the queue.
        /// </remarks>
        /// </summary>
        /// <param name="node">The object to add to the Queue<![CDATA[<TElement>]]>. The value can be null for reference types.</param>
        /// <param name="priority">The parameter is ignored.</param>
        public override void Enqueue(TElement node, double priority = 0)
        {
            Queue.Enqueue(node);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int Size()
        {
            return Queue.Count;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override bool IsEmpty()
        {
            return Queue.Count == 0;
        }
        #endregion

    }
    #endregion
}
