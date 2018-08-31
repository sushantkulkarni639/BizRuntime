using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class TestGenerics<T>                           //generic class
    {
        public void add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
        public void sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
    }
    class Generics2
    {
        static void Main(string[] args)
        {
            TestGenerics<int> tg = new TestGenerics<int>();
            tg.add(10,20);
            tg.sub(50,10);
            Console.ReadLine();

        }
    }
}
