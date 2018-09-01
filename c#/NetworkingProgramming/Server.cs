using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ServerNetworkingProgramming
{
    //Server Side Programming
    class Server
    {
        static void Main(string[] args)
        {
            try
            {
                //Server Programming
                IPAddress ip = IPAddress.Parse("127.0.0.1"); // ip address of string form is converted to instance
                TcpListener tcp = new TcpListener(ip, 8888); // port no. is provided to listener class 
                tcp.Start(); // starts the connection 
                Console.WriteLine("The server is running at port 8888");
                Console.WriteLine("The local End point is  :" + tcp.LocalEndpoint); //shows ip and port no. 
                Console.WriteLine("Waiting for a connection");
                Socket s = tcp.AcceptSocket(); // accept the connection
                Console.WriteLine("Connection accepted from " + s.RemoteEndPoint); // ip address and port is got
                byte[] b = new byte[100];
                int k = s.Receive(b); // the string sent frm client is converted in byte format and stored in array
                Console.WriteLine("Recieved...");
                for (int i = 0; i < k; i++)
                Console.Write(Convert.ToChar(b[i])); // now the byte format is converted into character value
                ASCIIEncoding asen = new ASCIIEncoding(); // now to display the char values in the console we use  ascii class
                s.Send(asen.GetBytes("The string was recieved by the server"));
                Console.WriteLine("\nSent Acknowledgement");
                // clean up /
                //s.Close();
               // myList.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            Console.Read();
        }
    }
}
