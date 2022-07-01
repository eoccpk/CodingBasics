using System;
using System.Threading;

namespace _20220702_ThreadsTimer
{
    public class ExampleThreadMain
    {
        public void Run()
        {
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";
            Console.WriteLine("I am {0}", th.Name);
        }
    }
}
