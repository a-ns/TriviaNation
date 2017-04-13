using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quobject.SocketIoClientDotNet.Client;

namespace NetworkLayerInterfaces
{
    public interface INetwork
    {
        bool SetEndPointLocation(String location);

        Socket getSocket();

        void setSocket(Socket value);

    }
}
