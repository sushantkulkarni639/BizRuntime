using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class PrintFromConsole
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter yr name");
            string s = Console.ReadLine();
            Console.WriteLine("yr name is " + s);
            Console.Read();
           
        }
    }
}
