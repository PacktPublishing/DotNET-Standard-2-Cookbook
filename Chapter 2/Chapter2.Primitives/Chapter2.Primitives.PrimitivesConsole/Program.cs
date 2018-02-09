using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter2.Primitives.PrimitiveLib;

namespace Chapter2.Primitives.PrimitivesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHelper = new Helpers();
            var myGrade = myHelper.WhatIsMyGrade(65);
            Console.WriteLine($"You are current grade is {myGrade}");

            var cm = 15;
            var inches = myHelper.CmToInches(cm);
            Console.WriteLine($"{cm} centimeters in inches are {inches}");


            Console.ReadLine();
        }
    }
}
