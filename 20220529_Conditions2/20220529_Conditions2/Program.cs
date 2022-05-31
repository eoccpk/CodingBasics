using System;

namespace _20220529_Conditions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PassingMarks = 50;
            int Marks = 50;

            if (Marks >= PassingMarks)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            if (Marks >= PassingMarks)
            {
                Console.WriteLine("Pass");
            }
            else if (1 == 2)
            {
                Console.WriteLine("Fail");
            }
            else if (2 == 3)
            {
                Console.WriteLine("Fail");
            }

            Console.ReadKey();
        }
    }
}
