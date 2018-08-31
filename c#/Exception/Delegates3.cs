using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics         //MultiCast Delegates
{
    public delegate void RectDelegate(double width, double height);
    class Delegates3
    {
        public void GetArea(double width, double height)
        {
            Console.WriteLine(width*height);
        }
        public void GetPerimeter(double height, double width)
        {
            Console.WriteLine(2*(height+width));
        }
        static void Main(string[] args)
        {
            Delegates3 d = new Delegates3();
            RectDelegate rd = new RectDelegate(d.GetArea);
            rd += d.GetPerimeter;
            rd.Invoke(20.2, 88.2);
            Console.Read();
        }
    }
}
