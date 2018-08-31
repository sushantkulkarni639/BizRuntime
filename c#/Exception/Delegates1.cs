using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class Delegates1
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static string SayHello(string s)
        {
            return "Hello " + s;
        }
        static void Main(string[] args)
        {
            Delegates1 d = new Delegates1();
            d.AddNums(10, 50);
            string st = Delegates1.SayHello("World");
            Console.WriteLine(st);
            Console.Read();
        }
    }
}
