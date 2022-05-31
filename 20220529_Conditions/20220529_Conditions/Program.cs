using System;

namespace _20220529_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks = 90;

            if(marks == 80)
            {
                Console.WriteLine("Marks is equal to 80");
            }

            if (marks < 80)
            {
                Console.WriteLine("Marks is less than 80");
            }

            if (marks > 80)
            {
                Console.WriteLine("Marks is greater than 80");
            }

            Console.ReadKey();
        }
    }
}
