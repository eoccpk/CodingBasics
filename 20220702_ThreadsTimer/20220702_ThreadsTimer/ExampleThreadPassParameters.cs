using System;
using System.Threading;

namespace _20220702_ThreadsTimer
{
    public class ExampleThreadPassParameters
    {
        public void Run()
        {
            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(ThreadFunction);
            Thread thread1 = new Thread(threadStart);
            thread1.Name = "Thread # 1";

            int marks = 85;
            thread1.Start(marks);
            
            Console.ReadKey();
        }

        // This function will run on separate thread
        public static void ThreadFunction(object input)
        {
            Console.WriteLine("I am running on Child Thread");
            Console.WriteLine("My name is " + Thread.CurrentThread.Name);

            int marks = (int)input;
            Console.WriteLine("I received " + marks);
        }
    }
}
