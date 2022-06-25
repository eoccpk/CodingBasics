using _20220701_FileIO.Bookshop;
using System;

namespace _20220701_FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExampleTextFiles textFiles = new ExampleTextFiles();
            //textFiles.Write();
            //textFiles.Read();

            BooksManager manager = new BooksManager();
            manager.Write();
            manager.Read();

            Console.ReadKey();

        }
    }
}
