using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMA.CSharp.GUI.Factory
{
    public interface ITestFactory
    {
        string GetTestString();
    }

    public class TestFactory: ITestFactory
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
