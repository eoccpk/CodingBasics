using System;

namespace _20220605_Classes3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj1 = new Student();
            obj1.Show();

            Console.WriteLine("\n");

            Student obj2 = new Student(11, "Qadir", 50);
            obj2.Show();

            Console.ReadKey();
        }
    }
}
