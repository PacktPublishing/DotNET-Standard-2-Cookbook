using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var hostName = System.Net.Dns.GetHostName();
            var hostAddress = System.Net.Dns.GetHostAddresses(hostName);
            foreach(var ipaddres in hostAddress)
            {
                if (ipaddres.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    Console.WriteLine(ipaddres);
            }

            Console.ReadLine();
        }
    }
}
