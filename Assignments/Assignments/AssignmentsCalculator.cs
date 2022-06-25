using System;

namespace Assignments
{
    public class AssignmentsCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Calculation Error");
                return -9999;
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }
    }
}
