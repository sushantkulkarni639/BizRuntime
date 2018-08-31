using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class StackEg
    {
        public static void Main(string[] args)
        {
            Stack<string> names = new Stack<string>();
            names.Push("Sush");
            names.Push("Pavi");
            names.Push("Jak");
            names.Push("Rat");
            names.Push("Immu");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek: " + names.Peek());
            Console.WriteLine("Pop: " + names.Pop());
            Console.WriteLine("Peek : " + names.Peek());
            Console.Read();

        }
    }
}
