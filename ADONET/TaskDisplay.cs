using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADONET
{
    class TaskDisplay
    {
        static void Main(string[] args)
        {
            new TaskDisplay().DisplayTable();
        }
        public void DisplayTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=student; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("Select * from connect for xml auto", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                ds.Tables[0].WriteXml(@"E:\text.xml");
                Console.WriteLine("done: check the xml file");
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
