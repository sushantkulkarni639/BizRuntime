//Encapsulation
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class EncapsulationEg1
    {
        int id;
        string name;
        string place;
        int salary;
        public void get()
        {
            Console.WriteLine("enter details");
            this.id = Convert.ToInt32(Console.ReadLine());
            this.name = Console.ReadLine();
            this.place = Console.ReadLine();
            this.salary = Convert.ToInt32(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("id is"+this.id);
            Console.WriteLine("name is"+this.name);
            Console.WriteLine("place is"+this.place);
            Console.WriteLine("salary is"+this.salary);
            Console.Read();
        }

    }
    class encap
    {
        static void Main(string[] args)
        {
            EncapsulationEg1 c = new EncapsulationEg1();
            c.get();
            c.display();

        }
    }
}
