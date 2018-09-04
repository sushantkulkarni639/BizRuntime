using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace JsonSerialization
{
    class jsonSerialize
    {
        public string Institute
        {
            get;
            set;
        }
        public List<string> Courses
        {
            get;
            set;
        }
    }
    public class Lara
    {
        static void Main(string[] args)
        {
            jsonSerialize js = new jsonSerialize()
            {
                Institute = "Lara Technology",
                Courses =new List<string>()
                {
                    "Java",
                    "J2EE",
                    "Spring",
                    "Hibernate",
                    "SQL",
                    "Servlet",
                    "JSP"
                }

            };
            string s = JsonConvert.SerializeObject(js);
            Console.WriteLine(s);
            File.WriteAllText(@"Lara.json", s);
            Console.WriteLine("Check in the bin folder to c the json file");
            Console.Read();

        }
    }
}
