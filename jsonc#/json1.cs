using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialization
{
    class json1
    {
        public int ID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public bool Gender
        {
            get;
            set;
        }
        public DateTime DateOfBirth
        {
            get;
            set;
        }
    }
    public class SerDeser
    {
        static void Main(string[] args)
        {

            json1 js = new json1
            {
                ID = 123,
                Name = "sushant",
                Gender = true,
                DateOfBirth = new DateTime(1995, 08, 29)
            };

            // Serialize it.  
            string serializedJson = JsonConvert.SerializeObject(js);

            // Print on the screen.  
            Console.WriteLine(serializedJson);
        }
    }
}
