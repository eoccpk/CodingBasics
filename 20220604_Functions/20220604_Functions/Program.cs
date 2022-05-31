using System;

namespace _20220604_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            print();
            Console.WriteLine("After first function call");

            print();
            Console.WriteLine("After second function call");

            Console.ReadKey();
        }

        static void print()
        {
            Console.WriteLine("I am print function");
            Console.WriteLine("You called me to print this");
        }
    }
}
