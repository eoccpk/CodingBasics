using System;

namespace _20220605_Classes3
{
    internal class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Student()
        {
            RollNumber = 1;
            Name = "Default Name";
            Marks = 1;
        }

        public Student(int rollNumber, string name, int marks)
        {
            RollNumber = rollNumber;
            Name = name;
            Marks = marks;
        }

        public void Input()
        {
            Console.WriteLine("Enter Student RollNumber, Name and Marks");
            RollNumber = Convert.ToInt32(Console.ReadLine());
            Name = Console.ReadLine();
            Marks = Convert.ToInt32(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine("Roll Number: \t" + RollNumber);
            Console.WriteLine("Name: \t\t" + Name);
            Console.WriteLine("Marks: \t\t" + Marks);
        }


        // DRY - Don't Repeat Your Self
        // Current Date - 2000-01-01
        public int CalculateAge()
        {
            // 2022 - 2000 = 22
            int Age = DateTime.Now.Year - DateOfBirth.Year;
            return Age;
        }

        public void IsEligible()
        {
            if (CalculateAge() >= 18)
                Console.WriteLine("Eligible"); 
        }

    }
}
