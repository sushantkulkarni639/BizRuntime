    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class IndexerImplement
    {
        static void Main(string[] args)
        {
            IndexerEg ie = new IndexerEg(101,2500,"sushant","eee","s/w","blr");
            Console.WriteLine("Id:" + ie[0]);
            Console.WriteLine("salary:" + ie[1]);
            Console.WriteLine("name:" + ie[2]);
            Console.WriteLine("dpt:" + ie[3]);
            Console.WriteLine("job:" + ie[4]);
            Console.WriteLine("location:" + ie[5]);
            ie[2] = "prashant";
            ie[5] = "hbl";
            Console.WriteLine();
            Console.WriteLine("Id:" + ie[0]);
            Console.WriteLine("salary:" + ie[1]);
            Console.WriteLine("name:" + ie[2]);
            Console.WriteLine("dpt:" + ie[3]);
            Console.WriteLine("job:" + ie[4]);
            Console.WriteLine("location:" + ie[5]);
            Console.Read();
        }
    }
}
