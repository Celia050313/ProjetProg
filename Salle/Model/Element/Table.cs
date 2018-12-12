
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Element
{
    public class Table
    {

        public int NbPlaceLibre { get; set; }

        public bool Utilisé { get; set; }

        public string Etat { get; set; }
        public int ID { get; set; }


        public Table(int Nb, bool Util, string Etat, int id)
        {

            this.NbPlaceLibre = Nb;
            this.Utilisé = Util;
            this.Etat = Etat;
            this.ID = id;



        }

    }
}
