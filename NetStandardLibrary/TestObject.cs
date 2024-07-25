using System;

namespace NetStandardLibrary
{
    public class TestObject : ITestObject
    {
        public int numberToTest = 123;

        public void SayHello()
        {
            Console.WriteLine($"Hello from {this.GetType().Namespace}");
        }

        public int GiveNumberToTest()
        {
            return numberToTest;
        }
    }
}
