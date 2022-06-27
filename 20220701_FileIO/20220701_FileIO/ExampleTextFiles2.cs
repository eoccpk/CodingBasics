using System;
using System.IO;

namespace _20220701_FileIO
{
    internal class ExampleTextFiles2
    {
        public void Run()
        {
            string Text = "This is an example long text" + Environment.NewLine + "Where I am writing multiple lines of text" + Environment.NewLine + "and it has nothing to do with anything";
            string FilePath = "D:\\Github\\data1.txt";
            File.WriteAllText(FilePath, Text);

            string FileText = File.ReadAllText(FilePath);
            Console.WriteLine(FileText);
        }
    }
}
