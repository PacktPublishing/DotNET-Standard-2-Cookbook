using System;

using System.Linq;

namespace Chapter4.Delegates.DelegateLib
{
    public class Calculator
    {
        public delegate string Message(string msg);

        public string AddTwoNumbers(int n1, int n2, Message msg)
        {
            return msg($"The answer is : {n1 + n2}");
        }

        public string CountScoresMoreThan80(int[] scores)
        {
            var count = scores.Where(s => s > 80).Count();
            return $"There are {count} scores more than 80";
        }
    }
}
