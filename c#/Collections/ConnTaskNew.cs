using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class ConnTaskNew
    {
        public static object MessageBox
        {
            get;
            private set;
        }

        public static void Main()
        {
            var a=1 ;
            string num2;

            IDictionary<int, string> dict = new Dictionary<int, string>();

            Console.WriteLine("Enter how many values you want to add ");
            int count = Convert.ToInt32(Console.ReadLine());
            int l = 1;
            for (l = 1; l <= count; l++)
            {
                Console.WriteLine("enter the key :");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value");
                num2 = Console.ReadLine();

                Added(a, num2);
            }

            void Added(int i, string s)
            {
                try
                {
                    dict.Add(new KeyValuePair<int, string>(a, num2));
                    Console.WriteLine("successful");
                    if (dict.Contains(new KeyValuePair<int, string>(a, " ")))
                    {
                        --l;
                        dict.Add(new KeyValuePair<int, string>(a, num2));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("updated");
                }
            }
            /* for (int count1 = 0; count1 < dict.Count; count1++)
             {
                 var element = dict.ElementAt(count1);
                 var Key = element.Key;
                 var Value = element.Value;
             }*/

            Console.WriteLine(dict.Count);
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            Console.Read();
        }
    }
}