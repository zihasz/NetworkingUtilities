using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NetworkingUtilities
{
    public interface IClient
    {
        // Properties
        IPAddress IP { get; set; }
        int Port { get; set; }
        TcpClient Client { get; }

        // Functions
        Stream Connect();
        void Disconnect();

        // Getters
        Stream GetStream();
        NetworkStream GetNetworkStream();
    }
}
