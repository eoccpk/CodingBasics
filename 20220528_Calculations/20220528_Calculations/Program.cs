using System;

namespace _20220528_Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            int c;

            c = a + b;
            Console.WriteLine("Result : " + c);

            c = a - b;
            Console.WriteLine("Result : " + c);

            c = a * b;
            Console.WriteLine("Result : " + c);

            c = a / b;
            Console.WriteLine("Result : " + c);

            Console.ReadKey();
        }
    }
}
