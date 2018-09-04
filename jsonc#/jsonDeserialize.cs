using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Collections;

namespace JsonSerialization
{
    public class jsonDeserialize
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
    public class DeSerialize
    {
        static void Main(string[] args)
        {
            jsonDeserialize jd = new jsonDeserialize()
            {
                Institute = "Lara Technology",
                Courses = new List<string>()
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
            string s1 = JsonConvert.SerializeObject(jd);
            Console.WriteLine(s1);
            File.WriteAllText(@"Lara.json", s1);
            s1=string.Empty;
            s1 = File.ReadAllText(@"Lara.json");
            Console.Read();
            IDictionary dc = JsonConvert.DeserializeObject<IDictionary>(s1);
            foreach(DictionaryEntry obj in dc)
            Console.WriteLine(obj.Key+" :" +obj.Value);
        }
    }
    }

