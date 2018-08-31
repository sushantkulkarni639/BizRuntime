using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace basics
{
    class FileReader2
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("e:\\b.txt", FileMode.OpenOrCreate);
            int i = 0;
            while ((i = f.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
            f.Close();
            Console.Read();
        }
    }
}
