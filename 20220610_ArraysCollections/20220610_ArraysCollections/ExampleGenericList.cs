using System;
using System.Collections.Generic;

namespace _20220610_ArraysCollections
{
    internal class ExampleGenericList
    {
        public void Run()
        {
            List<Student> students = new List<Student>();
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Enter Student #" + i +  ": ");
                Student student = new Student();
                student.Input();
                students.Add(student);
            }

            // Print All students
            Console.WriteLine("All Students Data: ");
            foreach (Student s in students)
            {
                s.Show();
            }
        }
    }
}
