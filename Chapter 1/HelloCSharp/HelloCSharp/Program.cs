using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = SayHello("Fiqri Ismail");
            Console.WriteLine(message);
            Console.ReadLine();
        }

        private static string SayHello(string yourName)
        {
            return $"Hello, {yourName}";
        }
    }
}
