using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class ListEx
    {
        public static void Main(string[] args)
        {  
            List<string> names = new List<string>();
            names.Add("sush");
            names.Add("Ankit");
            names.Add("k");
            names.Add("I");

            
            foreach (Object name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
