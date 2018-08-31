using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace basics
{
    class StringWriterEg
    {
        static void Main(string[] args)
        {
            string text = "Hello\n" +"World \n"; 
            StringBuilder sb = new StringBuilder(); 
            StringWriter writer = new StringWriter(sb);
            writer.WriteLine(text);
            writer.Flush();  
            writer.Close();
            StringReader reader = new StringReader(sb.ToString()); 
            while (reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
            Console.Read();
        }
    }
}
