using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class PartialMethod
    {
        static void Main(string[] args)
        {
            Record myRecord = new Record(10, 15);// Initialized in PartialMethod1 and PartialMethod2
            myRecord.PrintRecord();
            Console.ReadLine();
        }
    }
}
