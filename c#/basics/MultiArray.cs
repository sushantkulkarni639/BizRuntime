using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class MultiArray
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0] = new int[4] { 10, 20, 30, 40 };
            a[1] = new int[2] { 10, 20 };
            a[2] = new int[3] { 10, 20, 30 };
            for(int r=0; r<a.Length; r++)
            {
                for(int c=0; c<a[r].Length;c++)
                {
                    Console.Write(a[r][c] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
      
        }
    }
}
