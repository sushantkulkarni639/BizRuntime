using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class MultiArrayPrinting
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3] { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };
            for(int r=0; r<3; r++)
            {
                for(int c=0; c<3;c++)
                {
                    Console.Write(a[r,c]+" ");
                }
                Console.WriteLine();

            }
            Console.Read();
        }
    }
}
