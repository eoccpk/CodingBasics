using System;

namespace _20220604_Functions3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Receiving function result in a variable
            int value = increase(50);
            Console.WriteLine("New value: " + value + "\n");

            // function result in a calculation
            int result = increase(10) * 5;
            Console.WriteLine("Result: " + result + "\n");

            // function result in print
            int marks = 80;
            Console.WriteLine(increase(marks));

            Console.ReadKey();
        }

        static int increase(int number)
        {
            Console.WriteLine("I am increase function");
            Console.WriteLine("I received: " + number);
            return number + 10;
        }
    }
}
