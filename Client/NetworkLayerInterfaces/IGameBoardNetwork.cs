using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLayerInterfaces
{
    public interface IGameBoardNetwork
    {
        void setGameBoardNetwork(INetwork network);

        void gameBoardSetupSocket();

        void TileClick(int tileNum);

        void AnswerClick(bool answer);
    }
}
