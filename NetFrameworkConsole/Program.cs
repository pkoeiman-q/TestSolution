using NetStandardLibrary;
using System;

namespace NetFrameworkConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var frameworkTestObject = new TestObject();
            frameworkTestObject.SayHello();

            var standardTestObject = new NetStandardLibrary.TestObject();
            standardTestObject.SayHello();

            #if DEBUG
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            #endif
        }
    }
}
