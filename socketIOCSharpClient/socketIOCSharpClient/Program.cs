using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quobject.SocketIoClientDotNet.Client;
using Newtonsoft.Json;

namespace socketIOCSharpClient
{
    public class Message
    {
        public string message { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = IO.Socket("http://localhost:3000");
            
            socket.On("message", (data) => 
            {
                Message response = JsonConvert.DeserializeObject<Message>(data.ToString());
                Console.WriteLine(response.message);
            });
            Console.ReadKey();
        }
    }
}
