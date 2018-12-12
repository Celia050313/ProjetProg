
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
            /// Génération aléatoire de goût ?
            /// ou génération fixe en fonction du type de client ainsi que de la catégorie ?
        }


        public void categorie() {
            /// Cette Méthode va décider du type de client
            /// ainsi que du type de commandes ?
        }

    }
}