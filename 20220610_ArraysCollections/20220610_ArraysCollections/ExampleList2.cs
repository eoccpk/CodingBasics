using System;
using System.Collections;

namespace _20220610_ArraysCollections
{
    internal class ExampleList2
    {
        public void Run()
        {
            ArrayList names = new ArrayList();
            Console.WriteLine("Enter 3 names: ");
            for (int i = 0; i < 3; i++)
            {
                names.Add(Console.ReadLine());
            }

            if(names.Contains("kamran"))
                Console.WriteLine("Congrats!, your name is in the list.");

            names.Sort();
            // Print sorted using foreach loop
            Console.WriteLine("Print Sorted: ");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }
        }
    }
}
