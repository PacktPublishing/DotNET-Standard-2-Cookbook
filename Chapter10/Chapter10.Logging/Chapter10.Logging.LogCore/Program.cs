using System;
using Chapter10.Logging.LogLib;

namespace Chapter10.Logging.LogCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var logDemo = new LoggerDemo();
            Console.WriteLine("Executing method 1");
            logDemo.CallMethod1();
            Console.WriteLine("Executing method 2");
            logDemo.CallMethod2();
            Console.WriteLine("Executing method 3");
            logDemo.CallMethod3();
            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();

        }
    }
}
