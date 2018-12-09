
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Element.Motionless{
    public class MachineALaver : Machine {

        public MachineALaver() {
        }

        public int Contenance;

        public void Time;
        
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