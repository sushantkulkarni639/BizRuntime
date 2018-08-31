using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    public class Overload
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static float add(float a, float b)
        {
            return a + b;
        }
    }
    public class TestOverloading
    {
        public static void Main()
        {
            Console.WriteLine(Overload.add(12, 23));
            Console.WriteLine(Overload.add(12.4f, 21.3f));
            Console.Read();
        }
    }
}
