
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Element{
    public class Client : _Element{

        public string Type { get; set; }

        public string typeCommande { get; set; }

        public Client(int id, string etat,string type, string typeComm)
        {
            ID = id;
            Etat = etat;
            Type = type;
            typeCommande = typeComm;


        }




        public void gout() {
            /// G�n�ration al�atoire de go�t ?
            /// ou g�n�ration fixe en fonction du type de client ainsi que de la cat�gorie ?
        }


        public void categorie() {
            /// Cette M�thode va d�cider du type de client
            /// ainsi que du type de commandes ?
        }

    }
}