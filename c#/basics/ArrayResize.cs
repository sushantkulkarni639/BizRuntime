using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class ArrayResize
    {
        static void Main(string[] args)
        {
            int[] a = new int[4] { 1, 2, 3, 4 };
            for(int i=0; i<4; i++)
            {
                Console.Write(i+" ");
            }
            int n = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref a, n);
            for(int i=0; i<4; i++)
            {
                Console.Write(i+" ");
            }
            Console.Read();
        }
    }
}
