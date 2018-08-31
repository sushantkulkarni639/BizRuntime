using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class SortedSetEg
    {
        public static void Main(string[] args)
        {
       
            SortedSet<string> names = new SortedSet<string>();
            names.Add("S");
            names.Add("A");
            names.Add("r");
            names.Add("n");
            names.Add("Ss");


            foreach (Object name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
 
