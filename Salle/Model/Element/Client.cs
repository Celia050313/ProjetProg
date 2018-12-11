
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
            /// Génération aléatoire de goût ?
            /// ou génération fixe en fonction du type de client ainsi que de la catégorie ?
        }

        public string etat() {
            return "En attente";
        }

        public void categorie() {
            /// Cette Méthode va décider du type de client
            /// ainsi que du type de commandes ?
        }

    }
}