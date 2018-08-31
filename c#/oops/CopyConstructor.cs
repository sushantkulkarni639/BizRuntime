using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class CopyConstructor
    {
        int EmpID;
        string EmpName;
        string EmpPlace;
        int EmpAge;
        public CopyConstructor()
        {
            this.EmpID = 0758;
            this.EmpName = "sushant";
            this.EmpPlace = "hsr";
            this.EmpAge = 14;
        }
       public CopyConstructor(CopyConstructor obj)
        {
            this.EmpID = obj.EmpID;
            this.EmpName = obj.EmpName;
            this.EmpPlace = obj.EmpPlace;
            this.EmpAge = obj.EmpAge;
        }
        public void display()
        {
            Console.WriteLine("Employee Details are:");
            Console.WriteLine("Employee ID is: " + this.EmpID);
            Console.WriteLine("Employee Name is: " + this.EmpName);
            Console.WriteLine("Emloyee Place is: " + this.EmpPlace);
            Console.WriteLine("employee Age is: " + this.EmpAge);
            
        }
        static void Main(string[] args)
        {
            CopyConstructor cc = new CopyConstructor();
            CopyConstructor cc1 = new CopyConstructor(cc);
            cc.display();
            Console.WriteLine("                   ");
            Console.WriteLine("Copy coustructor results");
            cc1.display();
            Console.Read();


        }
    }
}
