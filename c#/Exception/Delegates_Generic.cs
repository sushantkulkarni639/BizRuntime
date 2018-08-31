using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    public delegate double Delegate1(int x, float y, double z);
    public delegate void Delegate2(int x, float y, double z);
    public delegate double Delegate3(string s);
    class Delegates_Generic
    {
        public static double AddNums1(int x, float y, double z)
        {
            return x + y + z;
        }
        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine(x+y+z);
        }
        public static bool CheckLength(string s)
        {
            if (s.Length > 5)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Delegate1 obj = AddNums1;
            double result = obj.Invoke(10, 20.5f, 50.2);
            Console.WriteLine(result);
            Delegate2 obj2 = AddNums2;
            obj2.Invoke(10, 55.2f,12.5);
           //
            Console.Read();


        }
    }
}
