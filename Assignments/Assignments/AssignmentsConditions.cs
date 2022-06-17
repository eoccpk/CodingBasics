using System;

namespace Assignments
{
    public class AssignmentsConditions
    {
        public void One()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Both numbers are Equal");
            }
            else
            {
                Console.WriteLine("Numbers are NOT Equal");
            }
        }

        public void Two()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("This Number is POSITIVE: " + a);
            }
            else if (a < 0)
            {
                Console.WriteLine("This Number is NEGATIVE: " + a);
            }
        }

        public void Three()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("This Number is EVEN: " + a);
            }
            else
            {
                Console.WriteLine("This Number is ODD: " + a);
            }
        }

        public void Four()
        {
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age >= 18)
            {
                Console.WriteLine("You are ELIGIBLE");
            }
            else
            {
                Console.WriteLine("You are NOT ELIGIBLE");
            }
        }

        public void Five()
        {
            int a = Convert.ToInt32(Console.ReadLine()); // 10
            int b = Convert.ToInt32(Console.ReadLine()); // 50
            int c = Convert.ToInt32(Console.ReadLine()); // 100

            if(a > b && a > c)
            {
                Console.WriteLine(a + " is Maximum");
            } 
            else if(b > a && b > c)
            {
                Console.WriteLine(b + " is Maximum");
            }
            else
            {
                Console.WriteLine(c + " is Maximum");
            }
        }
    }
}
