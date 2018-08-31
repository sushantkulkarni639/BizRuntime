using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class HashsetEg
    {
        public static void Main(string[] args)
        {
          
            HashSet<string> names = new HashSet<string>();
            names.Add("S");
            names.Add("A");
            names.Add("P");
            names.Add("I");
            names.Add("A");

             
            foreach (Object name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
