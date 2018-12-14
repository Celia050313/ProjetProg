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
            Thread Server = new Thread(ServerSocket.StartListening);
            Server.Start();

            ClientSocket.StartClient(2);
            return 0;
        }
    }
}
