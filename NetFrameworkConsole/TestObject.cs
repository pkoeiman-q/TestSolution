using NetStandardLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameworkConsole
{
    public class TestObject : ITestObject
    {
        public void SayHello()
        {
            Console.WriteLine($"Hello from {this.GetType().Namespace}");
        }
    }
}
