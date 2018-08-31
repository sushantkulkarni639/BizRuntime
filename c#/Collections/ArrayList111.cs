using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace basics
{
    class ArrayList111
    {
        static void Main(string[] args)
        {
            ArrayList l = new ArrayList();
            l.Add("sssss");
            l.Add(1);
            //l.Add(l);
            Console.WriteLine(l.Capacity);
            foreach (object obj in l)
            Console.Write(obj+",");
            Console.WriteLine();
            l.Insert(1, 588);
            //l.Remove(1);
            foreach(object obj in l)
            Console.Write(obj +",");
            Console.Read();
        }
    }
}
