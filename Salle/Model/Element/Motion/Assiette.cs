
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace View.Element.Motion{
    public class Assiette : MotionElement {

        public Assiette() {
        }

        public bool AssietteSale;

        public string etat() {
            return "Utilisé";
        }

    }
}