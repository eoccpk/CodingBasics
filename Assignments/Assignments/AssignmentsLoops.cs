using System;

namespace Assignments
{
    public class AssignmentsLoops
    {
        public void One()
        {
            int counter = 0;
            while(counter < 5)
            {
                Console.WriteLine("Pakistan");
                counter++;
            }

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Pakistan");
            }
        }

        public void Two()
        {
            int counter = 1;
            while(counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }
        }

        // 1 + 2 + 3 + 4 + 5
        public void Three()
        {
            int sum = 0;
            for (int counter = 1; counter <= 5; counter++)
            {
                sum = sum + counter;
            }
            Console.WriteLine("The Sum of First 5 Numbers : " + sum);
        }

        public void Four()
        {
            int counter = 1;
            while(counter <= 5)
            {
                Console.WriteLine("Square of " + counter + " = " + (counter * counter));
                counter++;
            }
        }

        public void Five()
        {
            Console.Write("Please enter number:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("==============================");
            Console.WriteLine("========= Table of " + n + " =========");
            Console.WriteLine("==============================");
            for (int i = 1; i <= 10; i++)
            {
                //3 x 1 = 3
                //3 x 8 = 24
                Console.WriteLine(n + " x " + i + " = " + (n*i));
            }
        }
    }
}
