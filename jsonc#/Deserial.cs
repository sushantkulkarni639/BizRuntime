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
    public class Newton
    {
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<string> Roles { get; set; }
    }
    class Deserial
    {
        static void Main(string[] args)
        {
            //Newton js = new Newton
            //{
            //    ID = 123,
            //    Name = "sushant",
            //    Gender = true,
            //    DateOfBirth = new DateTime(1995, 08, 29)
            //};
    string json = @"{'Email': 'james@example.com','Active': true,'CreatedDate': '2013-01-20T00:00:00Z','Roles': ['User','Admin']}";
            //    // Serialize it.  
            //Deserial obj = JsonConvert.DeserializeObject<Deserial>(json);

            ////            // Print on the screen.  
            //           Console.WriteLine(obj);
            IDictionary d = JsonConvert.DeserializeObject<IDictionary>(json);
            foreach(DictionaryEntry obj in d)
                Console.WriteLine(obj.Key+":"+obj.Value);
        }
    }
}
