namespace AIMA.csharpLibrary.Search.Components
{
    /// <summary>
    /// Stores key-value pairs for efficiency analysis.
    ///  ///<para>
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
    public partial class Metrics
    {
        private Dictionary<string, string> Metric;

        public Metrics()
        {
            Metric = new Dictionary<string, string>();
        }

        public void set(string name, int i)
        {
            Metric.TryAdd(name, i.ToString());
        }

        public void set(string name, double d)
        {
            Metric.TryAdd(name, d.ToString());
        }

        public void incrementInt(string name)
        {
            set(name, getInt(name) + 1);
        }

        public void set(string name, long l)
        {
            Metric.TryAdd(name, l.ToString());
        }

        public int getInt(string name)
        {
            string value = Metric.TryGetValue(name, out string? s) ? s : "";
            return value.Equals("") ? 0 : Convert.ToInt32(value);
        }

        public double getDouble(string name)
        {
            string value = Metric.TryGetValue(name, out string? s) ? s : "";
            return value.Equals("") ? 0.0 : Convert.ToDouble(value);
        }

        public long getLong(string name)
        {
            string value = Metric.TryGetValue(name, out string? s) ? s : "";
            return value.Equals("") ? 0 : Convert.ToInt64(value);
        }

        public string get(string name)
        {
            return Metric.TryGetValue(name, out string? s) ? s : "";
        }

        public Dictionary<string, string>.KeyCollection keySet()
        {
            foreach (var item in Metric.Keys)
            {

            }
            return Metric.Keys;
        }

        /** Sorts the key-value pairs by key names and formats them as equations. */
        public string toString()
        {
            //TODO: set through the items in the dictonary and build string representation.
            //TreeMap<string, string> map = new TreeMap<string, string>(Metric);
            return "";//Metric?.ToString();
        }
    }
}
