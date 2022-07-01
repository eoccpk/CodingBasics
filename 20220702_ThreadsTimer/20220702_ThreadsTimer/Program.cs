using System;

namespace _20220702_ThreadsTimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExampleThreadMain exampleThreadMain = new ExampleThreadMain();
            //exampleThreadMain.Run();

            //ExampleThreadCreate exampleThreadCreate = new ExampleThreadCreate();
            //exampleThreadCreate.Run();

            //ExampleThreadDestroy exampleThreadDestroy = new ExampleThreadDestroy();
            //exampleThreadDestroy.Run();

            ExampleTimer exampleTimer = new ExampleTimer();
            exampleTimer.Run();

            Console.ReadKey();
        }
    }
}
