using System;

namespace _20220611_Strings
{
    public class ExampleStrings2
    {
        public void Run()
        {
            Console.WriteLine("\n===================================");
            Console.WriteLine("String Examples 2");
            Console.WriteLine("===================================");

            // ToUpper
            String BankName = "ubl";
            Console.WriteLine(BankName.ToUpper());

            // ToLower
            String CustomerName = "KAMRAN QADIR";
            Console.WriteLine(CustomerName.ToLower());

            // IsNullOrEmpty
            if (!String.IsNullOrEmpty(CustomerName))
            {
                Console.WriteLine("Customer Name is NOT Blank");
            }

            // Equals
            if (String.Equals(BankName, CustomerName))
            {
                Console.WriteLine("Both Strings are Equal");
            } 
            else
            {
                Console.WriteLine("Strings are NOT Equal");
            }

            // StartsWith
            if (CustomerName.StartsWith("K"))
            {
                Console.WriteLine(CustomerName + " starts with K ");
            }

            // EndsWith
            if (CustomerName.EndsWith("R"))
            {
                Console.WriteLine(CustomerName + " ends with R ");
            }
        }
    }
}
