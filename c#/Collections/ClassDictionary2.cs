using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class ClassDictionary2
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("name", "ddjslj");
            d.Add("age", 25);
            d.Add("email", "s@g.com");
            foreach (string key in d.Keys)
                Console.WriteLine(key+":"+ d[key]);
            Console.Read();

        }
    }
}