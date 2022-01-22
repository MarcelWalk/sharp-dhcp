using System.Net;
using System.Net.Sockets;

namespace sharpdhcp{
    public class MessageReceivedArgs : EventArgs{
        public byte[] Data { get; set; }
        public IPEndPoint Endpoint { get; set; }
    }
}