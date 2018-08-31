using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class ExceptionEg2
    {
         static void Main(string[] args)
        {
            try
            {
                int i = 10;
                int j = 0;
                int x = i /j;
                Console.Read();
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Finally block is executed");
                Console.Read();
            }
            Console.WriteLine("Rest of the code");
            Console.Read();
        }
    }
}
