using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace clients
{
    class Client
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint Ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
            Console.WriteLine("Client Message");
            socket.Connect(Ip);
            Client c = new Client();
            Task t1 = new Task(() => c.RecieveFromServer(socket));
            t1.Start();
            while (true)
            {
                string s1 = Console.ReadLine();
                byte[] br = Encoding.ASCII.GetBytes(s1);
                socket.Send(br);
            }
        }
        public void RecieveFromServer(Socket socket)
        {
            byte[] buffer = new byte[socket.SendBufferSize];
            while (true)
            {
                int length = socket.Receive(buffer);
                byte[] data = new byte[length];
                Array.Copy(buffer, data, length);
                Console.WriteLine("From Server:" + Encoding.ASCII.GetString(data));
            }

        }
    }
}