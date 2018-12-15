using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using Salle;

namespace Cuisine
{
    class ServerSocket
    {  
        public static long action= 0;

        public static Salle.Commande commande;


        public static void StartListening()
        {
            // Buffer pour les données entrantes
            byte[] bytes = new Byte[1024];

            // Récupère les données nécessaires pour la création et le fonctionnement de la socket serveur  
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            // Création de la socket TCP/IP  
            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

             
            try
            {
                // Lie la socket au point de terminaison et commence l'écoute sur le port
                listener.Bind(localEndPoint);
                listener.Listen(10);

                //Attend la connexion d'un client 
                while (true)
                {
                    Console.WriteLine("Waiting for a connection...");

                    // Accepte les connexions entrantes
                    Socket handler = listener.Accept();

                    //Reçoit les données et détermine quelle action effectuer
                    while (true)
                    {
                        
                        handler.Receive(bytes);

                        action = BitConverter.ToInt32(bytes, 0);

                        if ( action == 10)
                        {
                            Plongeur.demarrerLaveLinge();
                            Console.WriteLine("Lave Linge démarré");
                        }
                        else
                        {
                            commande = (Salle.Commande)bytes.DeSerialize();

                            //TODO start metod that prepares meals
                            

                            Console.WriteLine("Text received : {0}", commande.statut);
                        }

                                                                      

                        break;
                    }
                                                                          
                    //Répond au client  
                    byte[] msg = Encoding.ASCII.GetBytes("All good<EOF>");
                    handler.Send(msg);

                    //Libère les sockets
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
