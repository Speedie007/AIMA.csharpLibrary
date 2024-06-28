namespace AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents
{
    /// <summary>
    /// Stores PropertyKey-value pairs for efficiency analysis.
    ///<para>
    ///Author:Ruediger Lunde
    ///</para>
    ///<para>
    ///Author:Ravi Mohan
    ///</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 17 May 2024 - Date Last Updated: 17 May 2024</para>
    /// </summary>
    public partial class SearchMetrics
    {
        private Dictionary<string, string> Metric;
        /// <summary>
        /// 
        /// </summary>
        public SearchMetrics()
        {
            Metric = new Dictionary<string, string>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="i"></param>
        public void Set(string name, int i)
        {
            Metric.TryAdd(name, i.ToString());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="d"></param>
        public void Set(string name, double d)
        {
            Metric.TryAdd(name, d.ToString());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public void IncrementInt(string name)
        {
            Set(name, GetInt(name) + 1);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="l"></param>
        public void Set(string name, long l)
        {
            Metric.TryAdd(name, l.ToString());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int GetInt(string name)
        {
            string value = Metric.TryGetValue(name, out string? s) ? s : "";
            return value.Equals("") ? 0 : Convert.ToInt32(value);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public double GetDouble(string name)
        {
            string value = Metric.TryGetValue(name, out string? s) ? s : "";
            return value.Equals("") ? 0.0 : Convert.ToDouble(value);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public long GetLong(string name)
        {
            string value = Metric.TryGetValue(name, out string? s) ? s : "";
            return value.Equals("") ? 0 : Convert.ToInt64(value);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string Get(string name)
        {
            return Metric.TryGetValue(name, out string? s) ? s : "";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> keySet()
        {
            return Metric.Keys.ToList();
        }

        /** Sorts the PropertyKey-value pairs by PropertyKey names and formats them as equations. */
        public string toString()
        {
            //TODO: Set through the items in the dictionary and build string representation.
            //TreeMap<string, string> map = new TreeMap<string, string>(Metric);
            return "";//Metric?.ToString();
        }
    }
}
