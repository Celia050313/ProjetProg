
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Element.Motionless{
    public abstract class Machine : MotionLessElements {

        public Machine() {
        }

        public abstract Machine clone();

        //    public abstract etat() {
        //      // TODO implement here
        //}

        public abstract string getImg();


    }
}