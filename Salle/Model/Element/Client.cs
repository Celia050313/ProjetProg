
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Element{
    public class Client {


        public int ID { get; set; }
        public string Etat { get; set; }

        public Client(int id, string etat)
        {
            this.ID = id;
            this.Etat = etat;

        }

        public string Type { get; set; }

        public string typeCommande { get; set; }


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