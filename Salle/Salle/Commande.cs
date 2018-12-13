using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salle
{
    [Serializable]
    public class Commande
    {
        public int Type;

        public int numTable;

        public int nbPers;

        public int statut;
    }
}
