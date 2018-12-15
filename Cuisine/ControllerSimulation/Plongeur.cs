
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ControllerSimulation{
    public class Plongeur {

        public Plongeur() {
        }




        public void demarrerLaveVaisselle() {

            int sleep = 5000;
            ThreadStart dlv = new ThreadStart(dlv);
            t.Start();
            Thread.Sleep(1000);
            complete = true;
            t.Join();

            
         } 


    public void DebarrasserLaveLinge() {
            // TODO implement here
        }

        public void commander() {
            // TODO implement here
        }

        public void consommer() {
            // TODO implement here
        }

        public void debarasserLaveVaisselle() {
            // TODO implement here
        }

        public void ramasseObjSale() {
            // TODO implement here
        }

        public void laveEvier() {
            // TODO implement here
        }

        public void aideCuisiner() {
            // TODO implement here
        }

        public void debarrasserComptoir() {
            // TODO implement here
        }

        public void remplirLaveVaisselle() {
            // TODO implement here
        }

        public void remplirLaveLinge() {
            // TODO implement here
        }

        public void wait() {
            // TODO implement here
        }

    }
}