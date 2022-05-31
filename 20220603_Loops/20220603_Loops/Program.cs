using System;

namespace _20220603_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // While Loop
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            // For Loop
            int j = 0;
            for(j = 0; j < 5; j++)
            {
                Console.WriteLine(j);
            }

            // Do While Loop
            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k < 5);

            Console.ReadKey();
        }
    }
}
