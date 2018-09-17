using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Collections;

namespace Assesment

{
    public class JSONProgram
    {
        public static void Main(string[] args)
        {
            JSONserialization jser = new JSONserialization()
            {

                Name = Console.ReadLine(),
                Address = Console.ReadLine(),
                Phone = Convert.ToInt32(Console.ReadLine()),
                Email = Console.ReadLine(),
            };
            string ResultJSON = JsonConvert.SerializeObject(jser);//JsonCOnvert is a class in newtonsoft.json
            Console.WriteLine(ResultJSON);
            File.WriteAllText(@"E:\jser.json", ResultJSON);
            Console.WriteLine("stored");
            Console.Read();
            //if we want to read the file jser.json and deserialize it
            ResultJSON = String.Empty;
            ResultJSON = File.ReadAllText(@"jser.json");
            JSONserialization result = JsonConvert.DeserializeObject<JSONserialization>(ResultJSON);
            Console.WriteLine(result.ToString());
            Console.Read();
            IDictionary dc = JsonConvert.DeserializeObject<IDictionary>(ResultJSON);
            foreach (DictionaryEntry obj in dc)
                Console.WriteLine(obj.Key + " :" + obj.Value);
            Console.Read();

        }

    }
}
