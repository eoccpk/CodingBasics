using System;

namespace _20220611_Strings
{
    public class ExampleStrings1
    {
        public void Run()
        {
            Console.WriteLine("\n===================================");
            Console.WriteLine("String Examples 1");
            Console.WriteLine("===================================");

            // Creating string from Charachter array
            char[] letters = { 'W', 'e', 'l', 'c', 'o', 'm', 'e' };
            string message1 = new string(letters);
            Console.WriteLine("Message1: {0}", message1);
            char[] charArray = message1.ToCharArray();

            // Joining two strings
            String FirstName = "Kamran";
            String LastName = "Qadir";
            String message2 = FirstName + " " + LastName;
            Console.WriteLine("Message2: {0}", message2);

            // String length
            Console.WriteLine("Message2 Length: {0}", message2.Length);
            
        }
    }
}
