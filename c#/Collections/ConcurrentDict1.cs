using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;

namespace basics
{
    class ConcurrentDict1
    {
        static void Main(string[] args)
        {
            var a = 1;
            string num2;
            ConcurrentDictionary<int, string> dictionary = new ConcurrentDictionary<int, string>();
            Console.WriteLine("Enter how many values you want to add ");
            int count = Convert.ToInt32(Console.ReadLine());
            int l = 1;
            try
            {


                for (l = 1; l <= count; l++)
                {
                    Console.WriteLine("enter the key :");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value");
                    num2 = Console.ReadLine();

                    Added(a, num2);
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);

            }
            void Added(int i, string s)
            {
                try
                {
                   dictionary.AddOrUpdate(a,num2,(id,text)=>num2); 
                }
                finally
                {
                    Console.WriteLine("updated");
                }
            }
            Console.WriteLine(dictionary.Count);
            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            Console.Read();

        }

    }
}
