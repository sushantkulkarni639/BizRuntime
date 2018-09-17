using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADONETAssesment
{
    class TaskInsert
    {
        static void Main(string[] args)
        {
            new TaskInsert().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=student; integrated security=SSPI");
SqlCommand cm1 = new SqlCommand("insert into Employee(EmpId, fullname, managerId, dateOfJoining) values('1','ajit singh','1','01/01/2010')", con);
  SqlCommand cm2 = new SqlCommand("insert into Employee(EmpId, fullname, managerId, dateOfJoining) values('2','Chinna','1','01/31/2014')", con);
  SqlCommand cm3 = new SqlCommand("insert into Employee(EmpId, fullname, managerId, dateOfJoining) values('3','jothi','1','01/31/2014')", con);
  SqlCommand cm4 = new SqlCommand("insert into Employee(EmpId, fullname, managerId, dateOfJoining) values('4','richard','1','01/31/2014')", con);
  SqlCommand cm5 = new SqlCommand("insert into Employee(EmpId, fullname, managerId, dateOfJoining) values('5','siva','1','01/1/2014')", con);
  SqlCommand cm6 = new SqlCommand("insert into Employee(EmpId, fullname, managerId, dateOfJoining) values('6','ankit','1','11/31/2014')", con);
  SqlCommand cm7 = new SqlCommand("insert into Employee(EmpId, fullname, managerId, dateOfJoining) values('7','roja','7','01/31/2014')", con);
  SqlCommand cm8 = new SqlCommand("insert into Employee(EmpId, fullname, managerId, dateOfJoining) values('8','hitesh','8','01/05/2014')", con);
  SqlCommand cm9 = new SqlCommand("insert into Employee(EmpId, fullname, managerId, dateOfJoining) values('9','chandra','3','01/21/2014')", con);
  SqlCommand cm10 = new SqlCommand("insert into Employee(EmpId, fullname, managerId, dateOfJoining) values('10','gourav','6','01/31/2011')", con);
  SqlCommand cm11 = new SqlCommand("insert into Employee(EmpId, fullname, managerId, dateOfJoining) values('11','santanu','3','01/31/2013')", con);
  SqlCommand cm12 = new SqlCommand("insert into Employee(EmpId, fullname, managerId, dateOfJoining) values('12','subramanya','2','01/31/2015')", con);
                con.Open();
                cm1.ExecuteNonQuery();
                cm2.ExecuteNonQuery();
                cm3.ExecuteNonQuery();
                cm4.ExecuteNonQuery();
                cm5.ExecuteNonQuery();
                cm6.ExecuteNonQuery();
                cm7.ExecuteNonQuery();
                cm8.ExecuteNonQuery();
                cm9.ExecuteNonQuery();
                cm10.ExecuteNonQuery();
                cm11.ExecuteNonQuery();
                cm12.ExecuteNonQuery();
                Console.WriteLine("Record Inserted Successfully");
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
