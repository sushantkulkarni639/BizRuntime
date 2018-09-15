using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADONET
{
    class Inserting
    {
        static void Main(string[] args)
        {
            CreateTable();
            Console.Read();
        }
         static void CreateTable()
        {
            SqlConnection con = null;
            try
            {  
                con = new SqlConnection("data source=.; database=student; integrated security=SSPI");
                //SqlCommand cm = new SqlCommand("insert into student(id, name, email, join_date)" +
                   // "values('101', 'sushant', 'sushant@gmail.com', '12/09/2018')", con);
                SqlCommand cm1 = new SqlCommand("insert into student(id, name, email, join_date)" +
                    "values('102', 'amar', 'amar@yahoo.com', '17/12/2018')", con);
                //SqlCommand cm2 = new SqlCommand("insert into student(id, name, email, join_date)" +
                //    "values('103', 'laxman', 'laxman@yahoo.com', '09/11/2016')", con);
                //SqlCommand cm3 = new SqlCommand("insert into student(id, name, email, join_date)" +
                //    "values('104', 'anil', 'anil@yahoo.com', '22/01/2015')", con);
                con.Open();
                cm1.ExecuteNonQuery();
                //cm2.ExecuteNonQuery();
                //cm3.ExecuteNonQuery();
                //cm1.ExecuteNonQuery();
                Console.WriteLine("Record Inserted Successfully");


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
