using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    //Generic Method
    class Generics1
    {
        public void add<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
        public void substract<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void multi<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
        static void Main(string[] args)
        {
            Generics1 g = new Generics1();
            g.add(10, 20);
            g.substract<int>(50, 55);
            g.multi<double>(51.2, 1.5);
            Console.ReadLine();
        }
    }
}
