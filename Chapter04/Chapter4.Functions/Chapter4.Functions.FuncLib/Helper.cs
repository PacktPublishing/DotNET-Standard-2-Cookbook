using System;

namespace Chapter4.Functions.FuncLib
{
    public class Helper
    {
        public Func<int, int> AddOne = n => n + 1;

        public Func<int, bool> IsZero = n => n == 0;
    }
}
