using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Salle
{
    class ServerSocket
    {
        // Incoming data from the client.  
        public static long action = 0;

        public static Commande commandePrete;


        public static void StartListening()
        {
            // Data buffer for incoming data.  
            byte[] bytes = new Byte[1024];

            // Establish the local endpoint for the socket.  
            // Dns.GetHostName returns the name of the   
            // host running the application.  
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 12000);

            // Create a TCP/IP socket.  
            Socket listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and   
            // listen for incoming connections.  
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                // Start listening for connections.  
                while (true)
                {
                    Console.WriteLine("Waiting for a connection...");

                    // Program is suspended while waiting for an incoming connection.  
                    Socket handler = listener.Accept();

                    // An incoming connection needs to be processed.  
                    while (true)
                    {

                        handler.Receive(bytes);

                        action = BitConverter.ToInt32(bytes, 0);

                        commandePrete = (Commande)bytes.DeSerialize();

                            //TODO start metod that prepares meals


                        Console.WriteLine("Text received : {0}", commandePrete.statut);
                        



                        break;
                    }

                    // Send the response to the client.  
                    byte[] msg = Encoding.ASCII.GetBytes("All good<EOF>");

                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();

        }
    }
}
