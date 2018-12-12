
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Element{
    public class ChefDeRang {


        public int ID { get; set; }
        public string Etat { get; set; }

        public ChefDeRang(int id, string etat)
        {
            this.ID = id;
            this.Etat = etat;

        }


    }
}