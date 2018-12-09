
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Element.Motionless{
    public class FeuxDeCuisson : Machine {

        public int Capacite = 5;

        public FeuxDeCuisson() {
        }



        public override Machine clone()
        {
            return (Machine)this.MemberwiseClone();
        }


        public override string getImg()
        {
            throw new NotImplementedException();
            //return adresse img;
        }


    }
}