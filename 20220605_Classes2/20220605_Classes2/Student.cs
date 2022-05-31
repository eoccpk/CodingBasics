using System;

namespace _20220605_Classes2
{
    internal class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public void Show()
        {
            Console.WriteLine("Roll Number: \t" + RollNumber);
            Console.WriteLine("Name: \t\t" + Name);
            Console.WriteLine("Marks: \t\t" + Marks);
        }
    }
}
