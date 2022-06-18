using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class AssignmentsFunctions
    {
        public void One(int a, int b)
        {
            if(a > b)
            {
                Console.WriteLine("First Number " + a + " is Greater then Second Number " + b);
            }
            else
            {
                Console.WriteLine("Second Number " + b + " is Greater then First Number " + a);
            }
        }

        public void Two(int a, int b)
        {
            AssignmentsCalculator calculator = new AssignmentsCalculator();
            int result = calculator.Add(a, b);
            Console.WriteLine("Add Result = " + result);
            Console.WriteLine("Subtract Result = " + calculator.Subtract(a, b));
            Console.WriteLine("Multiply Result = " + calculator.Multiply(a, b));
            Console.WriteLine("Divide Result = " + calculator.Divide(a, b));
        }

        public void Three(int length, int width)
        {
            AreaCalculator areaCalculator = new AreaCalculator();
            Console.WriteLine("Area Result = " + areaCalculator.Area(length, width));
        }

        public void Four(int n)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("========= Table of " + n + " =========");
            Console.WriteLine("==============================");
            for (int i = 1; i <= 10; i++)
            {
                //3 x 1 = 3
                //3 x 8 = 24
                Console.WriteLine(n + " x " + i + " = " + (n * i));
            }
        }
    }
}
