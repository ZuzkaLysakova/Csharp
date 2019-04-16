using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TcpServerExapmle
{

    class TcpServer
    {
        public const string DefaultIpAddress = "127.0.0.1";
        public const int DefaultPort = 1200;
        private IMessageProccessor processor;
        public const int ListenerCount = 1;
        private Socket socket;
        public TcpServer(IMessageProccessor processor, string ipAddress, int port)
        {
            this.processor = processor;
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
            
            processor?.Process($"TCP Server listening on {endPoint.ToString()}");
            socket.Bind(endPoint);


            socket.Listen(ListenerCount);
            Socket acceptedSocket = socket.Accept();

            Byte[] acceptedData = new byte[acceptedSocket.SendBufferSize];

            int bufferCount = acceptedSocket.Receive(acceptedData);
            byte[] data = new byte[bufferCount];

            for (int i = 0; i < bufferCount; i++)
            {
                data[i] = acceptedData[i];
            }

            string message = Encoding.Default.GetString(data);
            //Console.WriteLine(message);

            processor?.Process(message);

        }

        public void Listen()
        {
            Socket acceptSocket = socket.Accept();
            byte[] receiveData = new byte[acceptSocket.SendBufferSize];

            while (true)
            {
                int bufferSize = acceptSocket.Receive(receiveData);
                byte[] data = new byte[bufferSize];
                for (int i = 0; i < bufferSize; i++)
                {
                    data[i] = receiveData[i];
                }
                string message = Encoding.Default.GetString(data);
                processor?.Process(message);
                if(message == "exit")
                {
                    break;
                }
            }
        }
    }
}
