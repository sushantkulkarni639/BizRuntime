using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    interface ITestInterface
    {
        void add(int a, int b);
    }
    interface ITest1 : ITestInterface
    {
        void sub(int a, int b);
    }
    public class intefaceclass : ITestInterface
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        static void Main(string[] args)
        {
            intefaceclass i = new intefaceclass();
            i.add(10, 200);
            Console.Read();
        }
    }
}
