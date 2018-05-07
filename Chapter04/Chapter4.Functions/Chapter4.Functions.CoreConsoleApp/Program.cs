using System;
using System.Linq;
using Chapter4.Functions.FuncLib;

namespace Chapter4.Functions.CoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var helper = new Helper();

            Console.WriteLine(helper.AddOne(5));

            int[] numbers = new int[] { 1, 0, 10, 0, 5, 0 };

            Console.WriteLine($"We have found {numbers.Count(helper.IsZero)} zeros.");

            Console.ReadLine();

            
            
        }
    }
}
