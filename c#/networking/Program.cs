using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace NetworkProgramming
{
    //Client Programming
    class Client
    {
        static void Main(string[] args)
        {
            try
            {
                TcpClient tcp = new TcpClient();
                tcp.Connect("128.1.0.9", 8080);
                String st = Console.ReadLine();
                Stream stm = tcp.GetStream();
                 ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(st);
                Console.WriteLine("Transmitting.....");

                stm.Write(ba, 0, ba.Length);

                byte[] b = new byte[100];
                int k = stm.Read(b, 0, 100);

                for (int i = 0; i < k; i++)
                    Console.Write(Convert.ToChar(b[i]));

                tcp.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            Console.Read();
        }
    }
}
