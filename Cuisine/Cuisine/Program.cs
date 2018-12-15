using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Cuisine
{
    class Program
    {
        static int Main(string[] args)
        {
            Thread ClientCuisine = new Thread(ClientSocket.StartClient);
            Thread ServerCuisine = new Thread(ServerSocket.StartListening);

            ServerCuisine.Start();

            Thread.Sleep(10000);
            ClientCuisine.Start();

            return 0;

            // FINALIZE
        }


    }
}