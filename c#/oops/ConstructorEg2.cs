// Parameterized Constructor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class ConstructorEg2
    {
        int i;
        string n;
        int a;
        public ConstructorEg2(int id, string name, int age)
        {
            this.i = id;
            this.n = name;
            this.a = age;
        }
        public void disp()
        {
            Console.WriteLine("id is " + this.i);
            Console.WriteLine("name is " + this.n);
            Console.WriteLine("age is " + this.a);
            Console.Read();
        }

    }
    public class construct2
    {
        static void Main(string[] args)
        {
            ConstructorEg2 cl = new ConstructorEg2(1, "sushanth", 25);
            cl.disp();
        }
    }
}
