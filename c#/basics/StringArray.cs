using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class StringArray
    {
        static void Main(string[] args)
        {
            //int[] a = new int[4] { 10, 20, 30, 40 };
            String[] s = new string[4] { "a", "s", "d", "f" };
            for (int i=0; i<4; i++)
            {
                Console.Write(s[i]+" ");
            }
            Console.ReadLine();

        }
    }
}
