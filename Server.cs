using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace sharpdhcp
{
    public class Server
    {
        private const int listenPort = 68;
        public event EventHandler<MessageReceivedArgs> MessageReceived;

        private void StartListener()
        {
            UdpClient listener = new UdpClient(listenPort);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, listenPort);

            try
            {
                while (true)
                {
                    byte[] bytes = listener.Receive(ref groupEP);
                    OnMessageReceived(new MessageReceivedArgs(){Data = bytes});
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                listener.Close();
            }
        }

        protected virtual void OnMessageReceived(MessageReceivedArgs e)
        {
            EventHandler<MessageReceivedArgs> handler = MessageReceived;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}