using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    public class PolymorphismEg3
    {
        public virtual void draw()
        {
            Console.WriteLine("drawing");
        }
    }
    public class Rectangle : PolymorphismEg3
    {
        public override void draw()
        {
            Console.WriteLine("rectangle");
        }

    }
    public class Circle : PolymorphismEg3
    {
        public override void draw()
        {
            Console.WriteLine("circle");
        }

    }
    public class Polymorphism
    {
        public static void Main()
        {
            PolymorphismEg3 s;
            s = new PolymorphismEg3();
            s.draw();
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
            Console.Read();

        }
    }
}
