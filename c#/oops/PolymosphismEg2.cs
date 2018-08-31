using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    public class PolymosphismEg2
    {
        public virtual void draw()
        {
            Console.WriteLine("drawing");
        }
    }
    public class Rectangle1 : PolymosphismEg2
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle");
        }

    }
    public class Circl1 : PolymosphismEg2
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle");
        }

    }
    public class TestPolymorp
    {
        public static void Main()
        {
            PolymosphismEg2 s;
            s = new PolymosphismEg2();
            s.draw();
            s = new Rectangle1();
            s.draw();
            s = new Circl1();
            s.draw();
            Console.Read();

        }
    }
}
