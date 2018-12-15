using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Salle
{
    class ClientSocket
    {
        public static void StartClient(Object action)
        {
            //Buffer pour les données entrantes  
            byte[] bytes = new byte[1024];

            //Connection à un serveur  
            try
            {
                //Récupère les informations du serveur
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

                //Création d'une socket TCP/IP    
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

               
                try
                {
                    //Se connecte au port distant 
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());

                    
                    // Encode les données suivant le paramètre passé
                    byte[] message = null;

                    switch ((int)action) {
                        case 1:
                            //Compteur lave-linge
                            message = BitConverter.GetBytes(10);
                            break;

                        case 2:
                            //Transmet commande
                             var commande = new Commande { Type = 1, numTable = 3, nbPers = 3, statut = 1};
                            message = commande.Serialize();

                            break;

                        default:
                            Console.WriteLine("Erreur");
                            break;
                    }


                    //Envoie les données    
                    sender.Send(message);

                    //Reçoit la réponse du serveur  
                    int bytesRec = sender.Receive(bytes);
                    Console.WriteLine("Echoed test = {0}", Encoding.ASCII.GetString(bytes, 0, bytesRec));

                    //Libère la socket
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
}
