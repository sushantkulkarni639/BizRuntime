using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    public abstract class Abstraction
    {
        public abstract void draw();
    }
    public class Rectangle11 : Abstraction
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle");
        }
    }
    public class Circle11 : Abstraction
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle");
        }
    }
    public class TestAbstract
    {
        public static void Main()
        {
            Abstraction s;
            s = new Rectangle11();
            s.draw();
            s = new Circle11();
            s.draw();
            Console.Read();
        }
    }
}
