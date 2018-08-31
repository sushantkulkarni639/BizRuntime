using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace basics
{
    class TextWriter1
    {
        static void Main(string[] args)
        {
            using(TextWriter writer = File.CreateText("e:\\f.txt"))
            {
                writer.WriteLine("Hello C#");
                writer.WriteLine("How to study c#");
            }
            Console.WriteLine("Data written successfully");
            Console.Read();
        }
    }
}
