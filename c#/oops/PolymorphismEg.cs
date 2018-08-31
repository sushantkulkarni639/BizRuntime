using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    public class PolymorphismEg
    {
        public virtual void eat()
        {
            Console.WriteLine("eating...");
        }
    }
    public class Dog : PolymorphismEg
    {
        public override void eat()
        {
            Console.WriteLine("eating bread...");
        }

    }
    public class TestPolymorphism
    {
        static void Main()
        {
            PolymorphismEg a = new Dog();
            a.eat();
            Console.Read();

        }
    }
}
