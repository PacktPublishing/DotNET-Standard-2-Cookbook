using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter4.Delegates.DelegateLib;

namespace Chapter4.Delegates.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            Calculator.Message message = DelegateMessage;

            Console.WriteLine(calculator.AddTwoNumbers(10, 20, message));
           

            int[] scores = new int[] { 10, 90, 50, 85, 30, 100, 45, 60 };
            Console.WriteLine(calculator.CountScoresMoreThan80(scores));

            Console.ReadLine();

        }

        static string DelegateMessage(string msg)
        {
            return msg;
        }
    }
}
