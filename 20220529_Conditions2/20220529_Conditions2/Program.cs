using System;

namespace _20220529_Conditions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PassingMarks = 50;
            int Marks = 55;

            if (Marks >= PassingMarks)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            Console.ReadKey();
        }
    }
}
