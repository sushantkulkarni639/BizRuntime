using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class ReadFromConsole
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("specify the no.");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine(c);
            Console.Read();
        }
    }
}
