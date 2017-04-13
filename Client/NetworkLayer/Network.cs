using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Quobject.SocketIoClientDotNet.Client;

using NetworkLayerInterfaces;

namespace NetworkLayer
{
    public class Network : INetwork
    {
        private Network() { }
        public static Network Instance
        {
            get
            {
                return instance;
            }
        }

        public Socket getSocket()
        {
            return _socket;
        }

        public void setSocket(Socket value)
        {
            this._socket = value;
        }

        public Socket socket
        {
            get
            {
                return _socket;
            }
            set
            {
                this._socket = value;
            }
        }

        public bool SetEndPointLocation(string location)
        {
            this.socket = IO.Socket(location);
            return true;
        }

        public Socket _socket;
        private static Network instance = new Network();
    }
}
