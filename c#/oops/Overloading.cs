using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class Overloading
    {
        public int add(int i, int j)
        {
            return i + j;
        }
        public float add(float i, int j)
        {
            return i + j;
        }
        public int add(int i, int j, int k)
        {
            return i + j + k;
        }
    }
    class ex1
    {
        static void Main(string[] args)
        {
            Overloading ol = new Overloading();
            Console.WriteLine("sum is:" +ol.add(10,30));
            Console.WriteLine("sume is:" + ol.add(2.5f, 10));
            Console.WriteLine("sum is:" + ol.add(10 , 40 , 70));
            Console.Read();

        }
    }
}
