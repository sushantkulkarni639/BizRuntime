using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace JsonSerialization
{
    class ListSerialize
    {
        public List<string> Cars
        {
            get;
            set;
        }
    }
    public class CarSerialize
    {
        static void Main(string[] args)
        {
            ListSerialize ls = new ListSerialize()
            {
                Cars = new List<string>()
                {
                    "Maruthi",
                    "Hundai",
                    "volvo",
                    "BMW",
                    "Audi",
                    "Tata",
                    "vw"
                }
            };
            string s = JsonConvert.SerializeObject(ls);
            Console.WriteLine(s);
            Console.Read();
        }
    }
}
