using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    interface Interface1
    {

    }
    interface Interface2
    {

    }
    class MultipleInterface: Interface1,Interface2
    {
        public void add()
        {
            Console.WriteLine("hello world");
        }
        static void Main(string[] args)
        {
            MultipleInterface mi = new MultipleInterface();
            mi.add();
            Console.Read();
        }
    }
}
