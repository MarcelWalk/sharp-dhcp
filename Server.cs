using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace sharpdhcp
{
    public class Server
    {
        private const int listenPort = 67;

        private bool _isListening = false;
        private CancellationToken _callationToken;

        public event EventHandler<MessageReceivedArgs> MessageReceived;

        public async Task<bool> StartListener()
        {
            UdpClient listener = new UdpClient(listenPort);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, listenPort);
            _isListening = true;

            try
            {
                while (_isListening)
                {
                    var recieveResult = await listener.ReceiveAsync();
                    OnMessageReceived(new MessageReceivedArgs() { Data = recieveResult.Buffer, Endpoint = recieveResult.RemoteEndPoint });
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

            return true;
        }

        public void StopListener()
        {
            _isListening = false;
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