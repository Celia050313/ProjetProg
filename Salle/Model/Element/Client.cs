
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace View.Element.Motion{
    public class Client : MotionElement {

        public Client() {
        }

       public string Type="";

       public string typeCommande="";


        public void gout() {
            /// G�n�ration al�atoire de go�t ?
            /// ou g�n�ration fixe en fonction du type de client ainsi que de la cat�gorie ?
        }

        public string etat() {
            return "En attente";
        }

        public void categorie() {
            /// Cette M�thode va d�cider du type de client
            /// ainsi que du type de commandes ?
        }

    }
}