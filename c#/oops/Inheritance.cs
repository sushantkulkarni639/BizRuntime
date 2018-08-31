using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class Inheritance
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
            Console.WriteLine("-------------------------  ");
            Console.WriteLine("Bank Details are");
            Console.WriteLine("Branch Code is: " + this.BranchCode);
            Console.WriteLine("Bank Branch is: " + this.BankBranch);
            Console.WriteLine("Bank Name is: " + this.BankName);
        }
    }
    class BankEmployee1 : Inheritance
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
            Console.WriteLine(" ------------------------");
            Console.WriteLine("Employee Details are");
            Console.WriteLine("Id of the Employee is: " + this.EmployeeId);
            Console.WriteLine("Name od the Employee is: " + this.EmployeeName);
            Console.WriteLine("Age of the Employee is: " + this.EmployeeAge);
        }
    }
    class salary : BankEmployee1
    {
        double basic, hra, da, gross;
        public void getbasic()
        {
            Console.WriteLine("Please Enter the basic");
            this.basic = Convert.ToDouble(Console.ReadLine());
        }
        public void calculateSalary()
        {
            this.hra = basic * 05;
            this.da = basic * 05;
            this.gross = basic + da + hra;
        }
        public void salaryDisplay()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("The Salary details are");
            Console.WriteLine("Basic Salary is: " + this.basic);
            Console.WriteLine("HRA is: " + this.hra);
            Console.WriteLine("DA is: " + this.da);
            Console.WriteLine("gross Salary is: " + this.gross);
        }
    }
    class Bank1
    {
        static void Main(string[] args)
        {
            salary s = new salary();
            s.getBankDetails();
            s.getEmployeeDetails();
            s.getbasic();
            s.calculateSalary();
            s.displayBank();
            s.displayEmployee();
            s.salaryDisplay();
            Console.Read();
        }
    }
}
