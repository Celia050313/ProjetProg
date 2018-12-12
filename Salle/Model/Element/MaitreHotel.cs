
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Element{
    public class MaitreHotel {

        public string Etat { get; set; }
        public int ID { get; set; }

        public MaitreHotel(int id, string etat)
        {
            this.ID = id;
            this.Etat = etat;

        }


        public int DemandeNbPers() {
            // TODO implement here
            return 0;
        }


    }
}