
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace View.Element.Motion{
    public class Bouteille : MotionElement {

        public Bouteille() {
        }

        public String Contenu;

        public string etat() {
            return "Utilisé";
        }

    }
}