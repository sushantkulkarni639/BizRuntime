using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Assesment
{
    class Connection
    {
        static void Main(string[] args)
        {
            new Connection().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=student; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("create table Employee(Empid int not null,fullname varchar(100),managerId int, dateOfJoining date)", con);
                con.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine("Table created Successfully");
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

