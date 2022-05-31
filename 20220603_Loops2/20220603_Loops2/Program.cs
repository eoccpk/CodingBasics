using System;

namespace _20220603_Loops2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Break Statement
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;

                Console.WriteLine(i);
            }
            Console.WriteLine("Next line after Break");

            // Continue Statement - Skip the execution for counter 5
            for (int j = 0; j < 10; j++)
            {
                if (j == 5)
                    continue;

                Console.WriteLine(j);
            }
            Console.WriteLine("Next line after Continue");

            Console.ReadKey();
        }
    }
}
