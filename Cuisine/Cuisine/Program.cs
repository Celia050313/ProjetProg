using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using ControllerSim;

namespace Cuisine
{
    class Program
    {
        static int Main(string[] args)
        {
            SocketServer.StartListening();
            return 0;
            
           // FINALIZE
        }
    }
}
