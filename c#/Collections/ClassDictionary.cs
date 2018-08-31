using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class ClassDictionary
    {
        static void Main(string[] args)
        {
           Dictionary<string, object> d= new Dictionary<string, object>();
            d.Add("name", "sush");
            d.Add("place", "blr");
            d.Add("age", 25);
            d.Add("id", 10201);
            foreach (string key in d.Keys)
                Console.WriteLine(key + ":" + d[key]);
            Console.Read();

        }
    }
}
