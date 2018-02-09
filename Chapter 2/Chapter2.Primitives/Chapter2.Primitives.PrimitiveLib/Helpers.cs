using System;

namespace Chapter2.Primitives.PrimitiveLib
{
    public class Helpers
    {
        public char WhatIsMyGrade(int yourMarks)
        {
            var grade = 'F';

            if (yourMarks >= 85)
                grade = 'A';
            else if (yourMarks >= 65)
                grade = 'B';
            else if (yourMarks >= 55)
                grade = 'C';
            else if (yourMarks >= 35)
                grade = 'S';

            return grade;
        }

        public double CmToInches(double cm)
        {
            var oneCmToInches = 0.393700787;

            return oneCmToInches * cm; 

        }

        
    }
}
