
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Element{
    public class Serveur {

        public int ID { get; set; }
        public string Etat { get; set; }
        public string Nom { get; set; }
        public Serveur(int id, string etat, string nom) {
            this.ID = id;
            this.Etat = etat;
            this.Nom = nom;

        }



        

    }
}