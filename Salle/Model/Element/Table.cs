
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Element
{
    public class Table : _Element
    {

        public int NbPlaceLibre { get; set; }

        public bool Utilisé { get; set; }


        public Table(int Nb, bool Util, string etat, int id)
        {

            this.NbPlaceLibre = Nb;
            this.Utilisé = Util;
            ID = id;
            Etat = etat;


        }

    }
}
