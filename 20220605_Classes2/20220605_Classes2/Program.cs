using System;

namespace _20220605_Classes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj1 = new Student();
            obj1.RollNumber = 10;
            obj1.Name = "Kamran";
            obj1.Marks = 80;
            obj1.Show();

            Console.WriteLine("\n");

            Student obj2 = new Student();
            obj2.RollNumber = 11;
            obj2.Name = "Qadir";
            obj2.Marks = 50;
            obj2.Show();

            Console.ReadKey();
        }
    }
}
