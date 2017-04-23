using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameComponents;

namespace NetworkLayerInterfaces
{
    public interface IGameBoardNetwork
    {
        void setGameBoardNetwork(INetwork network);

        void gameBoardSetupSocket();

        void TileClick(Tile tile);

        void AnswerClick(bool answer);

        bool saveGame(Game game);

        Game loadGame(string gameName);
    }
}
