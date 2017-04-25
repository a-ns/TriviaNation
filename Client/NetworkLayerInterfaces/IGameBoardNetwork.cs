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

        void gameBoardSetupSocket(Action<Team> JoinedTeamCallback, Action<bool> StartGameCallback, Action<Tile> TileClickCallback, Action<Team> YourTurnCallback);

        void editGameBoardSetupSocket();

        void TileClick(Tile tile);

        void AnswerClick(bool answer);

        bool saveGame(Game game);

        Game loadGame(string gameName);

        void chooseTeam(Team chosenTeam);

        void beginGame();

        void yourTurn(Team yourTurn);
    }
}
