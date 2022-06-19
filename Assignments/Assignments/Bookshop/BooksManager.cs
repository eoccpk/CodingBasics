namespace Assignments.Bookshop
{
    public class BooksManager
    {
        public void Run()
        {
            Book b1 = new Book();
            b1.Input();

            b1.Print();
            
            b1.Borrow();
        }
    }
}
