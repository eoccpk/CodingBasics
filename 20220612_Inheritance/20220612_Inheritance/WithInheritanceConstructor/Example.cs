using System;

namespace _20220612_Inheritance.WithInheritanceConstructor
{
    public class Example
    {
        public void Run()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("=====Inheritance Constructor Call========");
            Console.WriteLine("=========================================");
            Student student = new Student("CNIC-123", "Student123", 123, 500);
            Console.WriteLine("Student Data");
            student.Show();
            Console.WriteLine("=========================================");
            Teacher teacher = new Teacher("CNIC-321", "Teacher321", 321, "Coding");
            Console.WriteLine("Teacher Data");
            teacher.Show();

            /*
             * We can save it in Person type
             * - set Parent class show function as *virtual*
             * - change Child class show function as *override*
            */
            //Person student = new Student("CNIC-123", "Student123", 123, 500);
            //student.Show();
            //Person teacher = new Teacher("CNIC-321", "Teacher321", 321, "Coding");
            //teacher.Show();
        }
    }
}
