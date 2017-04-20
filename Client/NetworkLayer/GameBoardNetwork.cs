using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
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

        public void gameBoardSetupSocket()
        {
            
        }

        public void TileClick(int tileNum)
        {
            //Emit the tile number so the server can broadcast the selection to the other users.
        }

        public void AnswerClick(bool answer)
        {
            //Emit whether the answer was correct or not so that the server can update the other users gameboards
        }

        private Socket _socket;
        private INetwork network;
        private static GameBoardNetwork instance = new GameBoardNetwork();
    }
}
