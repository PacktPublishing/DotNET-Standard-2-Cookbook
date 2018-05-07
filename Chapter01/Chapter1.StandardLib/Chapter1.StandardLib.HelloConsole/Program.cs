using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter1.StandardLib;

namespace Chapter1.StandardLib.HelloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var myName = "Fiqri Ismail";
            var helloMessage = new HelloUniverse();

            Console.WriteLine(helloMessage.SayHello(myName));
            Console.ReadLine();

        }
    }
}
