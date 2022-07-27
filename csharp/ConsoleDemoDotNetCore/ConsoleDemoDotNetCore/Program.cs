using System;

namespace ConsoleDemoDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start the Main already!");

            //ParallelDemo.ForeachLoop();
            //AccountTest.Main();
            //LockTest.RunTest();
            CloneCopyPrototypeDemo.RunDemo();

            Console.WriteLine("End Main method");
            Console.ReadKey();
        }
    }
}
