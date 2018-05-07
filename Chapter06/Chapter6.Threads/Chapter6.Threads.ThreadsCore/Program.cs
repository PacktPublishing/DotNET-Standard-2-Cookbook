using System;
using Chapter6.Threads.ThreadLib;

namespace Chapter6.Threads.ThreadsCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var threads = new ThreadGenerator();

            var output = threads.StartThreads();

            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}
