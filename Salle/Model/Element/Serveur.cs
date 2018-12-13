
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Element{
    public class Serveur : _Element {


        public string Nom { get; set; }


        public Serveur(int id, string etat, string nom) {
            ID = id;
            Etat = etat;
            Nom = nom;

        }



        

    }
}