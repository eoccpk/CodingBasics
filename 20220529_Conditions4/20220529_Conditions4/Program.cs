using System;

namespace _20220529_Conditions4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of the day");
            int n = 10;// Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Monday");
                    Console.WriteLine("Hello We are good.");
                    Console.WriteLine("3rd line");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("No Case Matched");
                    break;
            }

            Console.ReadKey();
        }
    }
}
