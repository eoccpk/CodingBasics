using System;
using System.Threading;

namespace _20220702_ThreadsTimer
{
    public class ExampleThreadCreate
    {
        public void Run()
        {
            Console.WriteLine("In Main Thread: Creating the Child thread\n\n");

            ThreadStart threadStart = new ThreadStart(ThreadFunction);

            Thread thread1 = new Thread(threadStart);
            thread1.Name = "Thread # 1";
            thread1.Start();
            
            Console.ReadKey();
        }

        // This function will run on separate thread
        public static void ThreadFunction()
        {
            Console.WriteLine("I am running on Child Thread");
            Console.WriteLine("I am going to Pause for 10 seconds (10*1000 miliseconds), then I will show you my Name");

            Thread.Sleep(5 * 1000);

            Console.WriteLine("My name is " + Thread.CurrentThread.Name);

        }
    }
}
