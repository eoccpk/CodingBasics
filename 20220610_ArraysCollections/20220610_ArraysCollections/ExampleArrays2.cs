using System;

namespace _20220610_ArraysCollections
{
    public class ExampleArrays2
    {
        // This function prints Maximum number in the arry
        public void Run()
        {
            int[] marks = new int[5];

            // Input all elements of the array
            Console.WriteLine("Enter 5 Numbers: ");
            for (int i = 0; i < marks.Length; i++)
                marks[i] = Convert.ToInt32(Console.ReadLine());

            int max = marks[0];
            for (int i = 0; i < marks.Length; i++)
            {
                if(marks[i] > max)
                    max = marks[i];
            }
            Console.WriteLine("Maximumn Number : " + max);
        }
    }
}
