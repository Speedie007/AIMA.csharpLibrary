namespace AIMA.CSharpLibrary.Common.DataStructure
{
    /// <summary>
    ///  /// <para>
    /// Author:Ravi Mohan
    /// </para>
    ///  /// <para>
    /// Author:Mike Stampone
    /// </para>
    ///  /// <para>
    /// Author:Ruediger Lunde
    /// </para>
    /// <para>
    /// Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    /// </para>
    /// <para>Date Created: 11 May 2024 - Date Last Updated: 26 May 2024</para>
    /// </summary>
    /// <typeparam name="X">First Item in the Pair</typeparam>
    /// <typeparam name="Y">Second Item in the Pair</typeparam>
    public partial  class Pair<X,Y>
    {
        /// <summary>
        /// Get the first element of the pair
        /// </summary>
        public X First { get; private set; }
        /// <summary>
        /// Get the second element of the pair
        /// </summary>
        public Y Second { get; private set; }
        public Pair(X first, Y second)
        {
            First = first;
            Second = second;
        }

        public override bool Equals(object? obj)
        {
            base.Equals(obj);
            if (obj != null && GetType() == obj.GetType())
            {
                Pair<X, Y> p = (Pair<X, Y>) obj;
                return Equals(First, p.First) && Equals(Second, p.Second);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (First == null ? 0 : 7 * First.GetHashCode()) + 31 * (Second == null ? 0 : Second.GetHashCode());
        }

        public override string? ToString()
        {
            return $"[{First},{Second}]";
        }
    }
}
