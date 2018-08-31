using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class StaticConstructor15
    {
        int i;
        static int j;
        public StaticConstructor15()
        {
            i = 55;
        }
        static StaticConstructor15()
        {
            j = 20;
        }
        public void display()
        {
            Console.WriteLine("The value of i is: " + i);
            i++;
            Console.WriteLine("The value of j is: " + j);
            j++;
        }
        static void Main(string[] args)
        {
            StaticConstructor15 sc = new StaticConstructor15();
            sc.display();
            StaticConstructor15 sc1 = new StaticConstructor15();
            sc1.display();
            StaticConstructor15 sc2 = new StaticConstructor15();
            sc2.display();
            Console.Read();
        }
    }
}
