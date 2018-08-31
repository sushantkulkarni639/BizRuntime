using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace basics
{
    class Threads1

    {
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("main method");
            Console.Read();
        }
        public static async void Method()
        {
            await Task.Run(new Action(LongTask));
            Console.WriteLine("new thread");
        }
        public static void LongTask()
        {
            Thread.Sleep(2000);
        }
    }
}
