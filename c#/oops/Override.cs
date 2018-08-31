using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    public class Override
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating");
        }
    }
    public class Dog1 : Override
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread");
        }
    }
    public class TestOverriding
    {
        public static void Main()
        {
            Dog1 d = new Dog1();
            d.eat();
            Console.Read();
        }
    }
}
