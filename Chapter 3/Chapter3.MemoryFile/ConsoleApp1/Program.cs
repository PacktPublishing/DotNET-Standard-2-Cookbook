using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter3.MemoryFile.MemFileLib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mem = new VirtualFile("testmap");
            mem.WriteToMemory();

            var list = mem.ReadFromMemory();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
