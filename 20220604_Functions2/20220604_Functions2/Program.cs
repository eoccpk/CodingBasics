using System;

namespace _20220604_Functions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            print(50);
            Console.WriteLine("After first function call");

            int marks = 80;
            print(marks);
            Console.WriteLine("After second function call");

            Console.ReadKey();
        }

        static void print(int number)
        {
            Console.WriteLine("I am print function");
            Console.WriteLine("I received: " + number);
        }
    }
}
