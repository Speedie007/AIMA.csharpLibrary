namespace AIMA.csharpLibrary.Common.DataStructure
{
    public partial  class Pair<X,Y>
    {
        /// <summary>
        /// Get the first element of the pair
        /// </summary>
        public X a { get; private set; }
        /// <summary>
        /// Get the second element of the pair
        /// </summary>
        public Y b { get; private set; }
        public Pair(X a, Y b)
        {
            this.a = a;
            this.b = b;
        }

        public override bool Equals(object? obj)
        {
            base.Equals(obj);
            if (obj != null && GetType() == obj.GetType())
            {
                Pair<X, Y> p = (Pair<X, Y>) obj;
                return Equals(a, p.a) && Equals(b, p.b);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
