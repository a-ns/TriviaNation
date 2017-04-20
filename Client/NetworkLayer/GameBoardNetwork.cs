using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkLayerInterfaces;
using Quobject.SocketIoClientDotNet.Client;

namespace NetworkLayer
{
    public class GameBoardNetwork : IGameBoardNetwork
    {
        private GameBoardNetwork()
        {

        }
        public static GameBoardNetwork Instance
        {
            get
            {
                return instance;
            }
        }
        public void setGameBoardNetwork(INetwork network)
        {
            this.network = network;
            this._socket = network.getSocket();
        }

        private Socket _socket;
        private INetwork network;
        private static GameBoardNetwork instance = new GameBoardNetwork();
    }
}
