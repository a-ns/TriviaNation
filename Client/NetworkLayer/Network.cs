using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Quobject.SocketIoClientDotNet.Client;
using PUser;
namespace NetworkLayer
{
    public class Network
    {
        private Network() { }
        public static Network Instance
        {
            get
            {
                return instance;
            }
        }

        private Socket socket
        {
            get
            {
                return _socket;
            }
            set
            {
                this._socket = value;
            }
        }

        public void SetupSocket(Action<String, String> MainMenuMessageBoxCallback)
        {
            this.socket.On("login", (data) =>
            {
                if (data != null)
                {
                    User foundUser = null;
                    foundUser = JsonConvert.DeserializeObject<User>(data.ToString());
                    Console.WriteLine("The user is " + foundUser.username + " " + foundUser.password);
                    MainMenuMessageBoxCallback("login","success");

                }
                if (data == null)
                {
                    Console.WriteLine("The user is null");
                    MainMenuMessageBoxCallback("login","failure");
                }
            });

            this.socket.On("signup", (data) =>
            {
                Console.WriteLine(data);
                Boolean success = (Boolean) data;
                MainMenuMessageBoxCallback("signup", success.ToString());
            });
        }

        public bool SetEndPointLocation(String location)
        {
            this.socket = IO.Socket(location);
            return true;
        }

        public void signup(String username, String password)
        {
            User user = new User();
            user.username = username;
            user.password = password;
            this.socket.Emit("signup", JsonConvert.SerializeObject(user));
        }

        public void signin(String username, String password)
        {
            User user = new User();
            user.username = username;
            user.password = password;
            this.socket.Emit("login", JsonConvert.SerializeObject(user));
        }


        private Socket _socket;
        private static Network instance = new Network();
    }
}
