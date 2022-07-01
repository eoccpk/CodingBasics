using System;
using System.Threading;

namespace _20220702_ThreadsTimer
{
    public class ExampleThreadDestroy
    {
        public void Run()
        {
            Console.WriteLine("In Main Thread: Creating the Child thread\n\n");

            ThreadStart threadStart = new ThreadStart(ThreadFunction);
            
            Thread thread = new Thread(threadStart);
            thread.Start();

            //stop the main thread for some time
            Thread.Sleep(5000);

            // Now abort the child
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("In Main Thread: Aborting the Child thread");
            thread.Abort();

            Console.ReadKey();

            
        }

        // This function will run on separate thread
        public static void ThreadFunction()
        {
            Console.WriteLine("I am running on Child Thread");
            Console.WriteLine("I am Counting from 101 to 110 but with Pause for 1 second (1000 miliseconds)");

            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Pause for 1 sec");
                    Thread.Sleep(1000);
                    Console.WriteLine(i);
                }
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine("Thread Abort Exception; Main Thread aborted Child Thread.");
            }
            finally
            {
                Console.WriteLine("Counting Done.");
            }

        }
    }
}
