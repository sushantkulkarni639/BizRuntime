using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallel
{
    class ParallelForEach
    {
        static void Main(string[] args)
        {
            List<string> Alphabets = new List<string>();
            Alphabets.Add("A");
            Alphabets.Add("Aa");
            Alphabets.Add("Aaa");
            Alphabets.Add("B");
            Alphabets.Add("Bb");
            Parallel.ForEach(Alphabets, new ParallelOptions { MaxDegreeOfParallelism = 5 }, fruit =>
            {
                Console.WriteLine("Fruit Name: {0}, Thread Id= {1}", fruit, Thread.CurrentThread.ManagedThreadId);
            }
                );
            //foreach(object obj in Alphabets)
            //    Console.WriteLine("Name: {0}, Thread Id= {1}",obj, Thread.CurrentThread.ManagedThreadId);
            Console.ReadLine();
        }
    }
}
