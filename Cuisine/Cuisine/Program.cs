﻿using System;
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
            Thread Client = new Thread(ClientSocket.StartClient);
            Thread Server = new Thread(ServerSocket.StartListening);

            Server.Start();

            Thread.Sleep(10000);
            Client.Start();
           // ServerSocket.StartListening();
            //ClientSocket.StartClient();
            return 0;

            // FINALIZE
        }


    }
}