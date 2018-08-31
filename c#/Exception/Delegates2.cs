using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    public delegate void AddDelegate(int a, int b);
    public delegate string SayDelegate(string s);
    class Delegates2
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static string SayHello(string s)
        {
            return "hello " + s;
        }
        static void Main(string[] args)
        {
            Delegates2 d = new Delegates2();
            AddDelegate ad = new AddDelegate(d.AddNums);
            ad(10, 20);
            SayDelegate sd = new SayDelegate(Delegates2.SayHello);
            string st = sd("world2");
            Console.WriteLine(st);
            ad.Invoke(10, 80);
            Console.Read();
        }
    }
}
