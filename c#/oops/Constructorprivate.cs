using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class Constructorprivate
    {
        int Pid;
        string Pname;
        string Paddress;
        int Page;
        private Constructorprivate()
        {
            this.Pid = 22;
            this.Pname = "sai";
            this.Paddress = "btm";
            this.Page = 25;
        }
        private void display()
        {
            Console.WriteLine("The details of person is listed below");
            Console.WriteLine("person id is: " + this.Page);
            Console.WriteLine("person name is: " + this.Pname);
            Console.WriteLine("person address is: " + this.Paddress);
            Console.WriteLine("person age is: " + this.Page);
            Console.Read();
        }
        static void Main(string[] args)
        {
            Constructorprivate cp = new Constructorprivate();
            cp.display();

        }
    }
}
