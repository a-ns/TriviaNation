using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Quobject.SocketIoClientDotNet.Client;
using PUser;
using NetworkLayerInterfaces;
using System.Threading.Tasks;

namespace NetworkLayer
{
    public class MainMenuNetwork : IMainMenuNetwork
    {
        TaskCompletionSource<Boolean> promise;
        private MainMenuNetwork()
        {
            
        }
        public static MainMenuNetwork Instance
        {

            get
            {
                return instance;
            }
        }

        public void setNetwork(INetwork network)
        {
            this.network = network;
            this._socket = network.getSocket();
        }


        public void MainMenuSetupSocket(Action<String, String> MainMenuMessageBoxCallback)
        {
            this._socket.On("login", (data) =>
            {
                if (data != null)
                {
                    User foundUser = null;
                    foundUser = JsonConvert.DeserializeObject<User>(data.ToString());
                    Console.WriteLine("The user is " + foundUser.username + " " + foundUser.password);
                    MainMenuMessageBoxCallback("login","success");
                    promise.TrySetResult(true);
                }
                if (data == null)
                {
                    Console.WriteLine("The user is null");
                    MainMenuMessageBoxCallback("login","failure");
                        promise.TrySetResult(false);
                }
            });

            this._socket.On("signup", (data) =>
            {
                Console.WriteLine(data);
                Boolean success = (Boolean) data;
                MainMenuMessageBoxCallback("signup", success.ToString());
            });
        }

        public bool MainMenuSetEndPointLocation(String location)
        {
            this._socket = IO.Socket(location);
            return true;
        }

        public void MainMenuSignUp(String username, String password)
        {
            User user = new User();
            user.username = username;
            user.password = password;
            this._socket.Emit("signup", JsonConvert.SerializeObject(user));
        }

        public bool MainMenuSignIn(String username, String password)
        {
            promise = new TaskCompletionSource<Boolean>();
            User user = new User();
            user.username = username;
            user.password = password;
            this._socket.Emit("login", JsonConvert.SerializeObject(user));
            promise.Task.Wait();
            if (this.promise.Task.Result)
            {
                promise = null;
                return true;
            }
            else
            {
                promise = null;
                return false;
            }

        }


        private Socket _socket;
        private INetwork network;
        private static MainMenuNetwork instance = new MainMenuNetwork();
    }
}
