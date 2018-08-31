using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    public abstract class Figure
    {
        public double height, width, radius;
        public float pi = 3.142f;
        public abstract double getarea();

    }
    public class Rectangle2 : Figure
    {
        public Rectangle2(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public override double getarea()
        {
            return width * height;
        }

    }
    public class Circle2 : Figure
    {
        public Circle2(double radius)
        {
            this.radius = radius;
        }
        public override double getarea()
        {
            return pi * radius * radius;
        }

    }
    public class Cone : Figure
    {
        public Cone(double height,double radius)
        {
            this.radius = radius;
            this.height = height;
        }
        public override double getarea()
        {
            return pi * radius * (radius + Math.Sqrt(height * height + radius * radius));
        }

    }
    public class AbstractImp
    {
        static void Main(string[] args)
        {
            Rectangle2 r = new Rectangle2(20.2, 5.2);
            Console.WriteLine(r.getarea());
            Circle2 c = new Circle2(23.3);
            Console.WriteLine(c.getarea());
            Cone cn = new Cone(20.1, 3.25);
            Console.WriteLine(cn.getarea() );
            Console.Read();
        }
    }
}
