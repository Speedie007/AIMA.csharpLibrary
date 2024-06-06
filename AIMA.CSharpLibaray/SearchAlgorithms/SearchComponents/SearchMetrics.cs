namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents
{
    /// <summary>
    /// Stores key-value pairs for efficiency analysis.
    ///<para>
    ///Author:Ruediger Lunde
    ///</para>
    ///<para>
    ///Author:Ravi Mohan
    ///</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 17 May 2024 - Date Last Updated: 17 May 2024</para>
    /// </summary>
    public partial class SearchMetrics
    {
        private Dictionary<string, string> Metric;

        public SearchMetrics()
        {
            Metric = new Dictionary<string, string>();
        }

        public void Set(string name, int i)
        {
            Metric.TryAdd(name, i.ToString());
        }

        public void Set(string name, double d)
        {
            Metric.TryAdd(name, d.ToString());
        }

        public void IncrementInt(string name)
        {
            Set(name, GetInt(name) + 1);
        }

        public void Set(string name, long l)
        {
            Metric.TryAdd(name, l.ToString());
        }

        public int GetInt(string name)
        {
            string value = Metric.TryGetValue(name, out string? s) ? s : "";
            return value.Equals("") ? 0 : Convert.ToInt32(value);
        }

        public double GetDouble(string name)
        {
            string value = Metric.TryGetValue(name, out string? s) ? s : "";
            return value.Equals("") ? 0.0 : Convert.ToDouble(value);
        }

        public long GetLong(string name)
        {
            string value = Metric.TryGetValue(name, out string? s) ? s : "";
            return value.Equals("") ? 0 : Convert.ToInt64(value);
        }

        public string Get(string name)
        {
            return Metric.TryGetValue(name, out string? s) ? s : "";
        }

        public List<string> keySet()
        {
            return Metric.Keys.ToList();
        }

        /** Sorts the key-value pairs by key names and formats them as equations. */
        public string toString()
        {
            //TODO: Set through the items in the dictonary and build string representation.
            //TreeMap<string, string> map = new TreeMap<string, string>(Metric);
            return "";//Metric?.ToString();
        }
    }
}
