using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Salle
{
    class Program
    {
        static int Main(string[] args)
        {
            Thread ServerSalle = new Thread(ServerSocket.StartListening);
            Thread ClientSalle = new Thread(new ParameterizedThreadStart(ClientSocket.StartClient));

            ServerSalle.Start();

            Thread.Sleep(10000);
            ClientSalle.Start(2);
            return 0;
        }
    }
}
