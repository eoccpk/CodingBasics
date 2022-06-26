using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System;

namespace _20220701_FileIO.Bookshop
{
    public class BooksManager
    {
        public void Write()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("========= BooksManager Write ============");
            Console.WriteLine("=========================================");

            List<Book> books = new List<Book>();
            Book book;

            for (int i = 0; i < 2; i++)
            {
                book = new Book();
                book.Input();
                books.Add(book);
            }

            // Convert to JSON, CSV or XML
            string data = JsonConvert.SerializeObject(books);

            // Saving Books
            File.WriteAllText("D:\\GitHub\\books.json", data);

        }

        public void Read()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("========= BooksManager Read ============");
            Console.WriteLine("=========================================");

            // Read Text File
            string data = File.ReadAllText("D:\\GitHub\\books.json");

            // Convert String to List of Objects
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(data);

            foreach (Book book in books)
            {
                book.Print();
            }
        }
    }
}
