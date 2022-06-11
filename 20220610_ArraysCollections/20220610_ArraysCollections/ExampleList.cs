using System;
using System.Collections;

namespace _20220610_ArraysCollections
{
    internal class ExampleList
    {
        public void Run()
        {
            ArrayList marks = new ArrayList();
            Console.WriteLine("Adding some numbers:");
            marks.Add(56);
            marks.Add(84);

            // Add more
            Console.WriteLine("Enter 3 more numbers: ");
            for (int i = 0; i < 3; i++)
            {
                marks.Add(Convert.ToInt32(Console.ReadLine()));
            }

            marks.Sort();

            // Print sorted
            Console.WriteLine("Print Sorted: ");
            for (int i = 0; i < marks.Count; i++)
                Console.WriteLine(marks[i]);
        }
    }
}
