using System;

namespace _20220610_ArraysCollections
{
    public class ExampleArrays
    {
        public void Run()
        {
            int[] marks = new int[5] { 56, 84, 35, 72, 41 };

            Console.WriteLine("Data at First Location: " + marks[0]);
            marks[0] = 58;
            Console.WriteLine("Changed Data at First Location: " + marks[0]);

            Console.WriteLine("Data at Second Location: " + marks[1]);

            // Input all elements of the array
            Console.WriteLine("Enter 5 Numbers: ");
            for (int i = 0; i < marks.Length; i++)
                marks[i] = Convert.ToInt32(Console.ReadLine());

            // Print all elements of the array
            Console.WriteLine("Print All 5 Numbers: ");
            for (int i = 0; i < marks.Length; i++)
                Console.WriteLine(marks[i]);
        }
    }
}
