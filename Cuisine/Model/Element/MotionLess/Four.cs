
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Element.Motionless{
    public class Four : Machine {

        public bool Utilise;

        public Four() {
        }

        public override Machine clone() {
            return (Machine)this.MemberwiseClone();
        }

    }
}