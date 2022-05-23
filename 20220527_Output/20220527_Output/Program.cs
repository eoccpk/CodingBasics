using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220527_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print Value
            Console.WriteLine(80);
            Console.WriteLine("Kamran Qadir");

            // Print Variable
            int marks;
            marks = 80;
            Console.WriteLine(marks);

            marks = 50;
            Console.WriteLine(marks);

            // Print String and Variable
            Console.WriteLine("Your marks = " + marks);

            Console.ReadKey();
        }
    }
}
