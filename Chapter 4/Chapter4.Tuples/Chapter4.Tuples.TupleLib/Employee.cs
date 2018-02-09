using System;

namespace Chapter4.Tuples.TupleLib
{
    public class Employee
    {
        public (string, string, int) GetBasicDetails()
        {
            string firstName = "Fiqri";
            string lastName = "Ismail";
            int experience = 15;

            return (firstName, lastName, experience);

        }

        
    }
}
