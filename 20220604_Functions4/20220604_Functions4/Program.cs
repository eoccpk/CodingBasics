using System;

namespace _20220604_Functions4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks = 80;
            print(marks);
            
            Console.ReadKey();
        }

        static void print(int number)
        {
            Console.WriteLine("I am print function");
            Console.WriteLine("I received: " + number);

            // This marks is local variable inside print function
            int marks = 20;
            Console.WriteLine("Local Variable Marks value: " + marks);
            int result = marks + 10;
            Console.WriteLine("Local Variable Result value: " + result);

        }
    }
}
