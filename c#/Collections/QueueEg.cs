using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class QueueEg
    {
        public static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            names.Enqueue("S");
            names.Enqueue("P");
            names.Enqueue("J");
            names.Enqueue("R");
            names.Enqueue("I");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek  " + names.Peek());
            Console.WriteLine("Dequeue: " + names.Dequeue());
            Console.WriteLine("Peek element: " + names.Peek());
            Console.Read();
        }
        
    }
}
