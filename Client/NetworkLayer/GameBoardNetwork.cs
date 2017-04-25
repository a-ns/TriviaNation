using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NetworkLayerInterfaces;
using Quobject.SocketIoClientDotNet.Client;
using GameComponents;

namespace NetworkLayer
{
    public class GameBoardNetwork : IGameBoardNetwork
    {
        TaskCompletionSource<Boolean> promise;
        Game loadedGame;
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

        public void gameBoardSetupSocket(Action<Team> JoinedTeamCallback)
        {
            this._socket.On("joinTeam", (data) =>
            {
                if (data != null)
                {
                    JoinedTeamCallback(JsonConvert.DeserializeObject<Team>(data.ToString()));
                }
                else
                    JoinedTeamCallback(null);
            });

            this._socket.On("answerClicked", (data) =>
            {

            });

            this._socket.On("questionClicked", (data) =>
            {

            });



            this._socket.On("scoreUpdate", (data) =>
            {

            });

            this._socket.On("saveGame", (data) =>
            {
                if (data != null)
                {
                    Game newGame = null;
                    try
                    {
                        newGame = JsonConvert.DeserializeObject<Game>(data.ToString());
                        Console.WriteLine("Game: " + newGame.gameName + " successfully created.");
                        promise.TrySetResult(true);
                    }
                    catch (Newtonsoft.Json.JsonReaderException)
                    {
                        promise.TrySetResult(false);
                    }
                }
                else if (data == null)
                {
                    Console.WriteLine("Game name is already taken.");
                    promise.TrySetResult(false);
                }
            });

            this._socket.On("loadGame", (data) =>
            {
                if (data != null)
                {
                    Game foundGame = null;
                    foundGame = JsonConvert.DeserializeObject<Game>(data.ToString());
                    Console.WriteLine("The game is " + foundGame.gameName);
                    loadedGame = foundGame;
                    promise.TrySetResult(true);
                }
                if (data == null)
                {
                    Console.WriteLine("The user is null");
                    promise.TrySetResult(false);
                }
            });
        }

        public void TileClick(Tile tile)
        {
            //Emit the tile number so the server can broadcast the selection to the other users.
            this._socket.Emit("questionClicked", JsonConvert.SerializeObject(tile));
        }

        public void AnswerClick(bool answer)
        {
            //Emit whether the answer was correct or not so that the server can update the other users gameboards
        }

        public bool saveGame(Game game)
        {
            this.promise = new TaskCompletionSource<bool>();
            this._socket.Emit("saveGame", JsonConvert.SerializeObject(game));
            promise.Task.Wait();
            if (this.promise.Task.Result)
                return true;
            else
                return false;
        }

        public Game loadGame(string gameName)
        {
            loadedGame = new Game();
            loadedGame.gameName = gameName;
            this.promise = new TaskCompletionSource<bool>();
            this._socket.Emit("loadGame", JsonConvert.SerializeObject(loadedGame));
            promise.Task.Wait();
            if (this.promise.Task.Result)
            {
                Console.WriteLine("Loaded: " + loadedGame.gameName);
                return loadedGame;
            }
            else
                return null;
        }

        private Socket _socket;
        private INetwork network;
        private static GameBoardNetwork instance = new GameBoardNetwork();
    }
}
