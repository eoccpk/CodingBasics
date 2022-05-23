using System;

namespace _20220527_InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Output
            Console.WriteLine("UBL - Where you come first");

            // Input
            string CardNumber = Console.ReadLine();

            // Output
            Console.WriteLine("You entered Card Number: " + CardNumber);

            // Input
            int PINCode = int.Parse(Console.ReadLine());

            // Output
            Console.WriteLine("You entered PIN Code: " + PINCode);

            /* 
             * Processing Steps:
             * 1. Match CardNumber and PINCode with already saved
             * 2. If Matched, show next screen
             * 3. If DOES NOT matched, show error
            */ 

            Console.ReadKey();
        }
    }
}
