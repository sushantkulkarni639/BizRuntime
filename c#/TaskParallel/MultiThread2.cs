using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParallel
{
    class MultiThread2
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Method1);
            Thread t2 = new Thread(Method2);
            t1.Start();
            t2.Start();
            Console.Read();
        }
        public static void Method1()
        {
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine("hello");
                Thread.Sleep(500);
            }
        }
        public static void Method2()
        {
            for(int i=1; i<=7;i++)
            {
                Console.WriteLine("orld");
                Thread.Sleep(500);
                
            }
        }
    }
}
