using System.Collections;

namespace AIMA.CSharpLibrary.Common.DataStructure
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedHashSet<T> : ISet<T>
    where T : class
    {

        private readonly IDictionary<T, LinkedListNode<T>> dict;
        private readonly LinkedList<T> list;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialCapacity"></param>
        public LinkedHashSet(int initialCapacity)
        {
            dict = new Dictionary<T, LinkedListNode<T>>(initialCapacity);
            list = new LinkedList<T>();
        }
        /// <summary>
        /// 
        /// </summary>
        public LinkedHashSet()
        {
            dict = new Dictionary<T, LinkedListNode<T>>();
            list = new LinkedList<T>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public LinkedHashSet(IEnumerable<T> e) : this()
        {
            AddEnumerable(e);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <param name="initialCapacity"></param>
        /// <param name="e"></param>
        public LinkedHashSet(int initialCapacity, IEnumerable<T> e) : this(initialCapacity)
        {
            AddEnumerable(e);
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="e"><inheritdoc/></param>
        private void AddEnumerable(IEnumerable<T> e)
        {
            foreach (T t in e)
            {
                Add(t);
            }
        }

        // ISet implementation
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="item"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public bool Add(T item)
        {
            if (dict.ContainsKey(item))
            {
                return false;
            }
            LinkedListNode<T> node = list.AddLast(item);
            dict[item] = node;
            return true;
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other"><inheritdoc/></param>
        public void ExceptWith(IEnumerable<T> other)
        {
            ArgumentNullException.ThrowIfNull(other);
            foreach (T t in other)
            {
                Remove(t);
            }
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other"><inheritdoc/></param>
        public void IntersectWith(IEnumerable<T> other)
        {
            ArgumentNullException.ThrowIfNull(other);
            T[] ts = new T[Count];
            CopyTo(ts, 0);
            foreach (T t in ts)
            {
                if (!other.Contains(t))
                {
                    Remove(t);
                }
            }
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other"><inheritdoc/></param>
        /// <returns><inheritdoc/><inheritdoc/></returns>
        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            ArgumentNullException.ThrowIfNull(other);
            int contains = 0;
            int noContains = 0;
            foreach (T t in other)
            {
                if (Contains(t))
                {
                    contains++;
                }
                else
                {
                    noContains++;
                }
            }
            return contains == Count && noContains > 0;
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            ArgumentNullException.ThrowIfNull(other);
            int otherCount = other.Count();
            if (Count <= otherCount)
            {
                return false;
            }
            int contains = 0;
            int noContains = 0;
            foreach (T t in this)
            {
                if (other.Contains(t))
                {
                    contains++;
                }
                else
                {
                    noContains++;
                }
            }
            return contains == otherCount && noContains > 0;
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public bool IsSubsetOf(IEnumerable<T> other)
        {
            ArgumentNullException.ThrowIfNull(other);
            foreach (T t in this)
            {
                if (!other.Contains(t))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public bool IsSupersetOf(IEnumerable<T> other)
        {
            ArgumentNullException.ThrowIfNull(other);
            foreach (T t in other)
            {
                if (!Contains(t))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public bool Overlaps(IEnumerable<T> other)
        {
            ArgumentNullException.ThrowIfNull(other);
            foreach (T t in other)
            {
                if (Contains(t))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public bool SetEquals(IEnumerable<T> other)
        {
            ArgumentNullException.ThrowIfNull(other);
            int otherCount = other.Count();
            if (Count != otherCount)
            {
                return false;
            }
            return IsSupersetOf(other);
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other"><inheritdoc/></param>
        public void SymmetricExceptWith(IEnumerable<T> other)
        {
            ArgumentNullException.ThrowIfNull(other);
            T[] ts = new T[Count];
            CopyTo(ts, 0);
            HashSet<T> otherList = new HashSet<T>(other);
            foreach (T t in ts)
            {
                if (otherList.Contains(t))
                {
                    Remove(t);
                    otherList.Remove(t);
                }
            }
            foreach (T t in otherList)
            {
                Add(t);
            }
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other"><inheritdoc/></param>
        public void UnionWith(IEnumerable<T> other)
        {
            ArgumentNullException.ThrowIfNull(other);
            foreach (T t in other)
            {
                Add(t);
            }
        }

        // ICollection<TElement> implementation
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public int Count
        {
            get
            {
                return dict.Count;
            }
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return dict.IsReadOnly;
            }
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="item"><inheritdoc/></param>
        void ICollection<T>.Add(T item)
        {
            Add(item);
        }
        /// <summary>
        /// 
        /// </summary>
        public void Clear()
        {
            dict.Clear();
            list.Clear();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            return dict.ContainsKey(item);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(T item)
        {
            //LinkedListNode<T> node;
            if (!dict.TryGetValue(item, out LinkedListNode<T>? node))
            {
                return false;
            }
            dict.Remove(item);
            list.Remove(node);
            return true;
        }

        // IEnumerable<TElement> implementation
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        // IEnumerable implementation
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }

    }
}