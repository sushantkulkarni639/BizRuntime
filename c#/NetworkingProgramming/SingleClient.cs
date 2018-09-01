using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientNetwork
{
    //Single Client Program
    class SingleClient
    {
        static void Main(string[] args)
        {
                try
                {
                    TcpClient tcp = new TcpClient(); //tcp class is used for client connection purpose 
                    Console.WriteLine("Connecting");
                    tcp.Connect("127.0.0.1", 8888);
                    // use the same ipaddress as in the server program
                    Console.WriteLine("Connected");
                    Console.Write("Enter the string to be transmitted : ");
                    String str = Console.ReadLine(); // the string to be sent to the server is given
                    Stream stm = tcp.GetStream(); // reads the stream
                    ASCIIEncoding asen = new ASCIIEncoding(); // encodes to unicode
                    byte[] ba = asen.GetBytes(str); // here string is converted into byte and stored in an array
                    Console.WriteLine("Transmitting.....");
                    stm.Write(ba, 0, ba.Length); // writes byte 
                    byte[] bb = new byte[100];
                    int k = stm.Read(bb, 0, 100); // reads the stream of byte starting frm 0
                    for (int i = 0; i < k; i++)
                    Console.Write(Convert.ToChar(bb[i])); // converts from byte to string
                    tcp.Close();
                }

                catch (Exception e)
                {
                    Console.WriteLine("Error " + e.StackTrace);
                }
                Console.ReadLine();

        }
    }
}
