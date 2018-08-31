using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace basics
{
    class ConnDict
    {
        static void Main(string[] args)
        {
            ConcurrentDictionary<string, string> dictionary = new ConcurrentDictionary<string, string>();
            Console.WriteLine("Before update");
            Console.WriteLine("----------------");
            dictionary.AddOrUpdate("Monday","sushant",(item, it)=> "First");
            dictionary.TryAdd("Tuesday", "Second");
            dictionary.TryAdd("Thursday", "Third");
            dictionary.TryAdd("Friday", "Fourth");
            foreach (object obj in dictionary)
            Console.WriteLine(obj);
            Console.WriteLine(" ");
            Console.WriteLine("After Update");
            Console.WriteLine("--------------");
            string newValue;
            bool returnTrue = dictionary.TryUpdate("Monday", "New Value", "First"); //Returns true
            dictionary.TryGetValue("Monday", out newValue);
            Console.WriteLine(newValue); //Print "New Value"
            bool returnsFalse = dictionary.TryUpdate("Tuesday", "New Value 2", "No Value"); //Returns false
            dictionary.TryGetValue("Tuesday", out newValue);  //Returns "Second" Old value
            Console.WriteLine(newValue);    //Print "Second"
            foreach (object obj in dictionary)
            Console.WriteLine(obj);
            Console.Read(); 
        }
    }
}
