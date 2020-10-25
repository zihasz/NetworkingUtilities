using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace NetworkingUtilities
{
    public class Server
    {
        private TcpListener _listener;

        public int Port;
        public List<TcpClient> Clients = new List<TcpClient>();
        public bool Running = false;

        /// <summary>
        /// A wrapper for the class System.Net.TcpListener
        /// </summary>
        /// <param name="port">The port to listen on</param>
        public Server(int port = 8080)
        {
            Port = port;

            _listener = new TcpListener(IPAddress.Any, port);
        }

        /// <summary>
        /// Run the server, accept clients and store them in Server.Clients
        /// </summary>
        public void Run()
        {
            _listener.Start();
            while (Running)
            {
                TcpClient client = _listener.AcceptTcpClient();
                Clients.Add(client);
            }
        }
    }
}
