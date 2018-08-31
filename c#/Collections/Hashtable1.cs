using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace basics
{
    class Hashtable1
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("name", "sush");
            ht.Add("place", "blr");
            ht.Add("Age", 25);
            foreach (Object key in ht.Keys)
                //Console.WriteLine(ht[key]);
                Console.WriteLine(key+":"+  ht[key]);
                //Console.WriteLine(ht["name"]);
            Console.Read();
        }
    }
}
