//Constructor Example
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class Constructor1
    {
        int id;
        string name;
        string place;
        int age;
        public Constructor1()
        {
            this.id = 20;
            this.name = "sushant";
            this.place = "blr";
            this.age = 22;
        }
        public void display()
        {
            Console.WriteLine("id is " + id);
            Console.WriteLine("name is " + name);
            Console.WriteLine("place is " + place);
            Console.WriteLine("age is " + age);
            Console.Read();
        }
    }
    public class construct
    {
        static void Main(string[] args)
        {
            Constructor1 cl = new Constructor1();
            cl.display();

        }
    }
}
