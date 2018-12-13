
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
            /// Génération aléatoire de goût ?
            /// ou génération fixe en fonction du type de client ainsi que de la catégorie ?
        }


        public void categorie() {
            /// Cette Méthode va décider du type de client
            /// ainsi que du type de commandes ?
        }

    }
}