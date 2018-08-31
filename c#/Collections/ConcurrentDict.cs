using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;

namespace basics
{
    class ConcurrentDict
    {
        static void Main(string[] args)
        {
            ConcurrentDictionary<int, string> dictionary = new ConcurrentDictionary<int, string>();
            dictionary.AddOrUpdate(1, "sushant", (id, text) => "sushant");
            dictionary.AddOrUpdate(1, "sagar", (id, text) => "sagar");
            dictionary.AddOrUpdate(2, "laxman", (id, text) => "laxman");
            dictionary.AddOrUpdate(3, "amar", (id, text) => "amar");
            dictionary.AddOrUpdate(4, "anil", (id, text) => "anil");
            dictionary.AddOrUpdate(4, "div", (id, text) => "div");
            foreach (KeyValuePair<int, string> value in dictionary)
            {
                Console.WriteLine("{0} - \"{1}\"", value.Key, value.Value);
            }
            Console.Read();

        }
    }
}
