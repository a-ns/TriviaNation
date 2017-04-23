using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Quobject.SocketIoClientDotNet.Client;
using NetworkLayerInterfaces;
using System.Threading.Tasks;
using GameComponents;

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


        public void MainMenuSetupSocket()
        {
            this._socket.On("login", (data) =>
            {
                if (data != null)
                {
                    User foundUser = null;
                    foundUser = JsonConvert.DeserializeObject<User>(data.ToString());
                    Console.WriteLine("The user is " + foundUser.username + " " + foundUser.password);
                    promise.TrySetResult(true);
                }
                if (data == null)
                {
                    Console.WriteLine("The user is null");
                    promise.TrySetResult(false);
                }
            });

            this._socket.On("signup", (data) =>
            {
                if (data != null)
                {
                    User newUser = null;
                    try {
                        newUser = JsonConvert.DeserializeObject<User>(data.ToString());
                        Console.WriteLine("Username " + newUser.username + " and login successfully created.");
                        promise.TrySetResult(true);
                    }
                    catch (Newtonsoft.Json.JsonReaderException)
                    {
                        promise.TrySetResult(false);
                    }
                    }
                else if(data==null)
                {
                    Console.WriteLine("Username is already taken.");
                    promise.TrySetResult(false);
                }
            });
        }

        public bool MainMenuSignUp(String username, String password)
        {
            promise = new TaskCompletionSource<Boolean>();
            User user = new User();
            user.username = username;
            user.password = password;
            this._socket.Emit("signup", JsonConvert.SerializeObject(user));
            promise.Task.Wait();
            if (this.promise.Task.Result)
                return true;
            else
                return false;
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
                return true;
            else
                return false;

        }


        private Socket _socket;
        private INetwork network;
        private static MainMenuNetwork instance = new MainMenuNetwork();
    }
}
