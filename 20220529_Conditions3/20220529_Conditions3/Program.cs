using System;

namespace _20220529_Conditions3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PassingMarks = 50;
            int Marks = 55;

            char Gender = 'M';

            // 1. Marks are greater then or equal to passing marks AND gender is male
            if ( (Marks >= PassingMarks) && (Gender == 'M') )
            {
                Console.WriteLine("Male is Pass");
            }

            // 2. Marks are greater then or equal to passing marks AND gender is female
            if ( (Marks >= PassingMarks) && (Gender == 'F') )
            {
                Console.WriteLine("FeMale is Pass");
            }

            // 3. Eligibility Criteria = Either Male or 8th semester student
            // All Males Eligible
            // Female from 8th semester
            int Semester = 8;
            if ((Gender == 'M') || (Semester == 8))
            {
                Console.WriteLine("Eligible");
            }

            // 4. It should print if fail
            // It will not print as it is Pass
            bool Pass = true;
            if (!Pass)
            {
                Console.WriteLine("Fail");
            }

            Console.ReadKey();
        }
    }
}
