namespace AIMA.CSharp.GUI.Factory
{
    public interface ITestFactory
    {
        string GetTestString();
    }

    public class TestFactory : ITestFactory
    {
        public TestFactory()
        {

        }

        public string GetTestString()
        {
            return "It Works" + DateTime.UtcNow.ToString();
        }
    }
}
