using Assignments.Bookshop;
using System;

namespace Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AssignmentsConditions conditions = new AssignmentsConditions();
            //conditions.One();
            //conditions.Two();
            //conditions.Three();
            //conditions.Four();
            //conditions.Five();

            //AssignmentsLoops loops = new AssignmentsLoops();
            //loops.One();
            //loops.Two();
            //loops.Three();
            //loops.Four();
            //loops.Five();

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            AssignmentsFunctions functions = new AssignmentsFunctions();
            //functions.One(a, b);
            //functions.Two(a, b);
            //functions.Three(a, b);
            //functions.Four(a);

            BooksManager manager = new BooksManager();
            manager.Run();

            Console.ReadKey();
        }
    }
}
