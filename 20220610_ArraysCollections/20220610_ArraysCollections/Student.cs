using System;

namespace _20220610_ArraysCollections
{
    internal class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public int[] Marks { get; set; }

        public Student()
        {
            RollNumber = 1;
            Name = "Default Name";
            Marks = new int[3];
        }

        public Student(int rollNumber, string name, int[] marks)
        {
            RollNumber = rollNumber;
            Name = name;
            Marks = marks;
        }

        public void Input()
        {
            Console.Write("Roll #: ");
            RollNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter 3 Marks: ");
            for (int i = 0; i < Marks.Length; i++)
                Marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine("Roll Number: \t" + RollNumber);
            Console.WriteLine("Name: \t\t" + Name);
            Console.WriteLine("Marks: \t\t" + String.Join(" ",Marks));
        }
    }
}
