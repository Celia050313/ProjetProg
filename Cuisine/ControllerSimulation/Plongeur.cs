using System;
using Model.Element;

namespace ControllerSimulation
{
    public class Plongeur {

        public Plongeur() {
        }

        bool allume = false;

        private void AffStatus()
        {
            string status = (allume == true) ? "ON" : "OFF";
            Console.WriteLine("La machine {0} est", status);
        }

        public bool DemarrerLaveVaisselle { 
            get {
                return allume;
            }
            set
            {
                allume = value;
                AffStatus();
            }
        }

        public bool DemarrerLaveLinge {
            get {
                return allume;
            }
            set
            {
                allume = value;
                AffStatus();
            }           
        }

        

        public void debarrasserLaveLinge() {
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