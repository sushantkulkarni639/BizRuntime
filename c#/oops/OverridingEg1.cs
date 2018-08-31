using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class OverridingEg1
    {
        int BranchCode;
        string BankBranch;
        string BankName;
        public void getBankDetails()
        {
            Console.WriteLine("Provide Bank Details");
            Console.WriteLine("Enter Branch code");
            this.BranchCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Branch Name");
            this.BankBranch = Console.ReadLine();
            Console.WriteLine("Enter Bank Name");
            this.BankName = Console.ReadLine();
        }
        public void displayBank()
        {
            Console.WriteLine("Branch Code is: " + this.BranchCode);
            Console.WriteLine("Bank Branch is: " + this.BankBranch);
            Console.WriteLine("Bank Name is: " + this.BankName);
        }
    }
    class BankEmployee : OverridingEg1
    {
        int EmployeeId;
        string EmployeeName;
        int EmployeeAge;
        public void getEmployeeDetails()
        {
            Console.WriteLine("           ");
            Console.WriteLine("Provide Employee Details");
            Console.WriteLine("Enter Employee Id");
            this.EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            this.EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter Employee Age");
            this.EmployeeAge = Convert.ToInt32(Console.ReadLine());

        }
        public void displayEmployee()
        {
            Console.WriteLine("Id of the Employee is: " + this.EmployeeId);
            Console.WriteLine("Name od the Employee is: " + this.EmployeeName);
            Console.WriteLine("Age of the Employee is: " + this.EmployeeAge);
        }
    }
    class Bank
    {
        static void Main(string[] args)
        {
            BankEmployee bk = new BankEmployee();
            bk.getBankDetails();
            bk.getEmployeeDetails();
            Console.WriteLine("-------------------------  ");
            Console.WriteLine("Bank Details are");
            bk.displayBank();
            Console.WriteLine(" ------------------------");
            Console.WriteLine("Employee Details are");
            bk.displayEmployee();
            Console.Read();
        }
    }
}
