using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace basics
{
    class StreamReaderEg
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("e:\\output.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            string line = s.ReadLine();
            Console.WriteLine(line);

            s.Close();
            f.Close();
            Console.Read();
        }
    }
}
