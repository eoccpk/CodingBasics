using System;

namespace _20220701_FileIO.Bookshop
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }
        public int PublicationYear { get; set; }

        public void Input()
        {
            Console.Write("Enter Title:");
            Title = Console.ReadLine();
            Console.Write("Enter Author:");
            Author = Console.ReadLine();
            Console.Write("Enter NumberOfPages:");
            NumberOfPages = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter PublicationYear:");
            PublicationYear = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("Title:" + Title);
            Console.WriteLine("Author:" + Author);
            Console.WriteLine("NumberOfPages:" + NumberOfPages); 
            Console.WriteLine("PublicationYear:" + PublicationYear);
        }

        public void Borrow()
        {
            Console.WriteLine("Borrow :" + Title);
        }
    }
}
