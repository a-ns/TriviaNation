using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkLayerInterfaces;

namespace NetworkLayer
{
    public class GameBoardNetwork : IGameBoardNetwork
    {
        private INetwork network;
        public GameBoardNetwork(Network endpoint)
        {
            this.endpoint = endpoint;
        }
    }
}
