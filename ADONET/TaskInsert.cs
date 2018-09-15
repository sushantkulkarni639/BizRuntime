using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADONET
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
                SqlCommand cm1 = new SqlCommand("insert into connect(id, name, email, age,salary)" +
                    "values('1','sushant kulkarni','sushant@gmail.com','25','15000')", con);
                SqlCommand cm2 = new SqlCommand("insert into connect(id, name, email, age,salary)" +
                    "values('2','laxman bizruntime','laxman@gmail.com','22','17000')", con);
                SqlCommand cm3 = new SqlCommand("insert into connect(id, name, email, age,salary)" +
                    "values('3','amardeep','amardeep@gmail.com','24','15500')", con);
                con.Open();
                cm1.ExecuteNonQuery();
                cm2.ExecuteNonQuery();
                cm3.ExecuteNonQuery();
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
