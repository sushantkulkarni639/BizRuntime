using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    // generic method
    class MethodGenerics
    {
        public void show<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
    class GenericEg
    {
        static void Main(string[] args)
        {
            MethodGenerics cg = new MethodGenerics();
            cg.show<string>("hello");// <string> is optional
            cg.show(100);
            cg.show('a');
            Console.ReadLine();
        }
    }
}
