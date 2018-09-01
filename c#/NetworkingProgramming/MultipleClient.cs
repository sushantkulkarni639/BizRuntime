using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientNetwork
{
    class MultipleClient
    {
        static void Main(string[] args)
        {
            //multiple client
            int port = 8087;
            string IpAdress = "127.0.0.1";
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // we r using interNetwork Address Family, socket is of stream type and protocol is tcp
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IpAdress), port);
            clientSocket.Connect(ep);
            Console.WriteLine("client connected");
            while (true)
            {
                string MessageFromClient = null;
                Console.WriteLine("enter the message");
                MessageFromClient = Console.ReadLine();
                clientSocket.Send(System.Text.Encoding.ASCII.GetBytes(MessageFromClient), 0, MessageFromClient.Length, SocketFlags.None);

                byte[] MsgFromServer = new byte[1024];
                int size = clientSocket.Receive(MsgFromServer);
                Console.WriteLine("server " + System.Text.Encoding.ASCII.GetString(MsgFromServer, 0, size));
            }
        }   
    }
    
}
