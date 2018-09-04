using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Collections;

namespace basics
{
    //Here we need a library called as Newtonsoft   library used to create and parse json data
    // used to serialize the normal string into json object
    // and also used to deserialize json data back into normal form 
    public class JSONProgram
    {
        public static void Main(string[] args)
        {
            JSONserialization jser = new JSONserialization()
            {
                Id = 11,
                Name = "sushant",
                Degree = "B.E",
                Age=25,
                Salary=15000,
                Hobbies = new List<string>()
            {
                "Reading",
                "Playing cricket"
            }
        };
            string ResultJSON = JsonConvert.SerializeObject(jser);//JsonCOnvert is a class in newtonsoft.json
            Console.WriteLine(ResultJSON);
            // all the values are converted into json format
            File.WriteAllText(@"jser.json", ResultJSON);
            Console.WriteLine("stored");
            Console.Read();
            // if we want to read the file jser.json and deserialize it
            ResultJSON = String.Empty;
            ResultJSON = File.ReadAllText(@"jser.json");
            JSONserialization result = JsonConvert.DeserializeObject<JSONserialization>(ResultJSON);
            Console.WriteLine(result.ToString());
            Console.Read();
            //IDictionary dc= JsonConvert.DeserializeObject<IDictionary>(ResultJSON);
            //foreach(DictionaryEntry obj in dc)
            //    Console.WriteLine(obj.Key+" :" +obj.Value);

        }
        
    }
}
