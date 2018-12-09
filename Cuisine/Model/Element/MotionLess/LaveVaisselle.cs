
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Element.Motionless{
    public class LaveVaisselle : Machine {


        public int ContenanceVerre = 0;

        public int ContenanceCouvert = 0;

        public int ContenanceAssiette = 0;

        public void Time;


        public LaveVaisselle() {
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