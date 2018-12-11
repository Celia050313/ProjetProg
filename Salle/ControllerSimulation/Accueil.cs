
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControllerSimulation{
    public class Accueil {

        public void accueil() {

        }

        public void paie() {
            Random alea = new Random();
            int prix = alea.Next(21);
        }

        public void ordonner() {
            // TODO implement here
        }

        public void assigneTable() {
            
        }

        public void groupe() {
            Random alea = new Random();
            int aleaFin = alea.Next(0, 19);
            int nbClient;
            bool arrivee = false;
            int pourcentage = alea.Next(19);

            if (arrivee == true)
            {
                if (aleaFin <= 4)
                {
                    nbClient = 2;
                }

                if (aleaFin > 4 && aleaFin <= 10)
                {
                    nbClient = 4;
                }

                if (10 > aleaFin && aleaFin <= 13)
                {
                    nbClient = 3;
                }

                if (13 < aleaFin && aleaFin <= 16)
                {
                    nbClient = 6;
                }

                if (16 < aleaFin && aleaFin <= 18)
                {
                    nbClient = 10;
                }
            
            }
            else
            {
                nbClient = 0;
            }
        }

        public void ordre() {
            // TODO implement here
        }

        public void wait() {
            bool statut = true;
        }

        public void reserver() {
            Random alea = new Random();
            int aleaRnd = alea.Next(0,5);
            if (aleaRnd < 3)
            {

            }
        }

    }
}