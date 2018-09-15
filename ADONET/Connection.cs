using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADONET
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
                    SqlCommand cm = new SqlCommand("create table student1(id int not null,name varchar(100),email varchar(50), join_date date)", con);  
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
  
