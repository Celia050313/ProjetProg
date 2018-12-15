using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Cuisine
{
    class ClientSocket
    {
        public static void StartClient()
        {
            //Buffer pour les données entrantes 
            byte[] bytes = new byte[1024];

            //Connection à un serveur 
            try
            {
                //Récupère les informations du serveur 
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 12000);

                //Création d'une socket TCP/IP  
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                
                try
                {   //Se connecte au port distant 
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());

                    //Encode les données
                    byte[] message = null;

                    var commande = new Salle.Commande { Type = 1, numTable = 3, nbPers = 3, statut = 2 };

                    message = commande.Serialize();


                    //Envoie les données  
                    sender.Send(message);

                    //Reçoit la réponse du serveur 
                    int bytesRec = sender.Receive(bytes);
                    Console.WriteLine("Echoed test = {0}",Encoding.ASCII.GetString(bytes, 0, bytesRec));

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
