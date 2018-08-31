using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    //Generic class
    class GeneicClass<T>
    {
        public GeneicClass(T msg)
        {
            Console.WriteLine(msg);
        }
    }
    class GenEg
    {
        static void Main(string[] args)
        {
            GeneicClass<string> gc = new GeneicClass<string>("hello");
            GeneicClass<int> gc1 = new GeneicClass<int>(100);
            GeneicClass<char> gc2 = new GeneicClass<char>('d');
            Console.Read();
        }
    }
}
