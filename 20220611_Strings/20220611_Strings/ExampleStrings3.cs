using System;

namespace _20220611_Strings
{
    public class ExampleStrings3
    {
        public void Run()
        {
            Console.WriteLine("\n===================================");
            Console.WriteLine("String Examples 3");
            Console.WriteLine("===================================");

            // Concat
            String[] StringArray = { "UBL", "Where", "You", "Come", "First" };
            String ConcatResult = String.Concat(StringArray);
            Console.WriteLine(ConcatResult);

            // Join
            String JoinResult = String.Join(" ", StringArray);
            Console.WriteLine(JoinResult);

            // Split
            String[] SplittedArray = JoinResult.Split(" ".ToCharArray());

            // Contains
            if (JoinResult.Contains("You"))
            {
                Console.WriteLine("It Contains word 'You' ");
            }

            // IndexOf
            int IndexOfResult = JoinResult.IndexOf("You");
            Console.WriteLine("word 'You' found at " + IndexOfResult);

            // Trim
            JoinResult += "     \n\n          ";
            Console.WriteLine(JoinResult + "End");
            String TrimResult = JoinResult.Trim(" \n".ToCharArray());
            Console.WriteLine(TrimResult);

            // SubString
            String SubStringResult = TrimResult.Substring(0, 3);
            Console.WriteLine(SubStringResult);

            // Replace
            String ReplaceResult = TrimResult.Replace("UBL", "HBL");
            Console.WriteLine(ReplaceResult);

        }
    }
}
