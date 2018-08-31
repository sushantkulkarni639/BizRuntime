using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallel
{
    class MultiThread1
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.Read();
        }
        public static void Method1()
        {
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine("Hello: "+i.ToString());
            }
        }
        public static void Method2()
        {
            for (int i = 0;i <= 10; i++)
            {
                Console.WriteLine( "world: "+i.GetHashCode());
            }
        }

    }
}
