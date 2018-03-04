using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter6.ThreadPools.PoolLib;

namespace Chapter6.ThreadPools.PoolConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var pool = new ThreadList();

            var output = pool.ProcessPool();

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
