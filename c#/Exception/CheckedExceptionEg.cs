using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class CheckedExceptionEg
    {
        static void Main(string[] args)
        {
            checked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
                Console.Read();
            }
        }
    }
}
