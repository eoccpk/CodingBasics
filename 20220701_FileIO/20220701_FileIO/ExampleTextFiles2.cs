using System;
using System.IO;

namespace _20220701_FileIO
{
    internal class ExampleTextFiles2
    {
        public void Run()
        {
            string Text = "asdsadsadasdasdsadsadasdasdsadsadasdasdsadsadasdasdsadsadasd";
            string FilePath = "D:\\Github\\text.bin";
            File.WriteAllText(FilePath, Text);

            string FileText = File.ReadAllText(FilePath);

        }
    }
}
