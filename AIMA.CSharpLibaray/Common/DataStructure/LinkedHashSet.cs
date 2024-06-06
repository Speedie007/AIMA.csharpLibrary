using System.Collections;

namespace AIMA.CSharpLibrary.Common.DataStructure
{
    public class LinkedHashSet<T> : ISet<T>
    where T : class
    {

        private readonly IDictionary<T, LinkedListNode<T>> dict;
        private readonly LinkedList<T> list;

        public LinkedHashSet(int initialCapacity)
        {
            dict = new Dictionary<T, LinkedListNode<T>>(initialCapacity);
            list = new LinkedList<T>();
        }

        public LinkedHashSet()
        {
            dict = new Dictionary<T, LinkedListNode<T>>();
            list = new LinkedList<T>();
        }

        public LinkedHashSet(IEnumerable<T> e) : this()
        {
            AddEnumerable(e);
        }

        public LinkedHashSet(int initialCapacity, IEnumerable<T> e) : this(initialCapacity)
        {
            AddEnumerable(e);
        }

        private void AddEnumerable(IEnumerable<T> e)
        {
            foreach (T t in e)
            {
                Add(t);
            }
        }

        // ISet implementation

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

        public void ExceptWith(IEnumerable<T> other)
        {
            ArgumentNullException.ThrowIfNull(other);
            foreach (T t in other)
            {
                Remove(t);
            }
        }

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

        public void UnionWith(IEnumerable<T> other)
        {
            ArgumentNullException.ThrowIfNull(other);
            foreach (T t in other)
            {
                Add(t);
            }
        }

        // ICollection<TElement> implementation

        public int Count
        {
            get
            {
                return dict.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return dict.IsReadOnly;
            }
        }

        void ICollection<T>.Add(T item)
        {
            Add(item);
        }

        public void Clear()
        {
            dict.Clear();
            list.Clear();
        }

        public bool Contains(T item)
        {
            return dict.ContainsKey(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

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

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        // IEnumerable implementation

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }

    }
}