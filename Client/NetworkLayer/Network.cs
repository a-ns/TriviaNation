using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Quobject.SocketIoClientDotNet.Client;
using User;
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

        public bool SetEndPointLocation(String location)
        {
            this.socket = IO.Socket(location);
            return true;
        }

        public void signup(String username, String password)
        {
            User.User user = new User.User();
            user.username = username;
            user.password = password;
            this.socket.Emit("signup", JsonConvert.SerializeObject(user));
        }


        private Socket _socket;
        private static Network instance = new Network();
    }
}
