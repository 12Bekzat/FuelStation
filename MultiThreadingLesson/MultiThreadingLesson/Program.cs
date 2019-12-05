using System;
using System.Collections.Generic;
using System.Threading;

namespace MultiThreadingLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentThread = Thread.CurrentThread;
            Console.WriteLine($"Поток {currentThread.ManagedThreadId} начал свою работу");

            //var thread = new Thread(ProcessWork);
            //thread.Start();

            var thread = new Thread(ProcessData);
            thread.Start(new List<Object>
            {
                new { Name = "asd" },
                new { Name = "jdkfsdfs" }
            });

            //ProcessWork();

            Console.WriteLine($"Поток {currentThread.ManagedThreadId} закончил свою работу");

            //Console.ReadLine();
        }

        static void ProcessWork()
        {
            var currentThread = Thread.CurrentThread;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"[{currentThread.ManagedThreadId}] - {i}");
                Thread.Sleep(500);
            }
        }

        static void ProcessData(object data)
        {
            Thread.Sleep(3000);
            foreach (var item in data as List<Object>)
            {
                Console.WriteLine(item);
            }
        }
    }
}
