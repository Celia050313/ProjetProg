
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Element.Motionless{
    public class Four : Machine {

        public bool Utilise = false;

        public Four() {
        }

        
        public override Machine clone() {
            return (Machine)this.MemberwiseClone();
        }

        public override string getImg()
        {
            throw new NotImplementedException();
            //return adresse img;
        }

    }
}