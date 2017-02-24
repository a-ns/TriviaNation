using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quobject.SocketIoClientDotNet.Client;
using Newtonsoft.Json;

namespace socketIOCSharpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var socket = IO.Socket("http://localhost:3000");
            
            socket.On("message", (data) => 
            {
                dynamic theMessage = JsonConvert.DeserializeObject(data.ToString());
                Console.WriteLine(theMessage.message);
            });
            Console.ReadKey();
        }
    }
}
