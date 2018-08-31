using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace basics
{
    class FileStreamEg
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("e:\\b.txt", FileMode.OpenOrCreate);
            f.WriteByte(64); 
            f.Close();
            Console.WriteLine("done");
            Console.Read();
        }
    }
}
