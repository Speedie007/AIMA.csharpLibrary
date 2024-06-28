namespace AIMA.CSharp.GUI.Factory
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITestFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetTestString();
    }
    /// <summary>
    /// 
    /// </summary>
    public class TestFactory : ITestFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TestFactory()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetTestString()
        {
            return "It Works" + DateTime.UtcNow.ToString();
        }
    }
}
