using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class LinkedListEg
    {
        public static void Main(string[] args)
        {
              
            LinkedList<string> names = new LinkedList<string>();
            names.AddLast("Son");
            names.AddLast("Anil");
            names.AddLast("Pavan");
            names.AddLast("sush");
  
            LinkedListNode<String> node = names.Find("Anil");
            names.AddBefore(node, "Son");
            names.AddAfter(node, "sohan");
 
            foreach (Object name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
