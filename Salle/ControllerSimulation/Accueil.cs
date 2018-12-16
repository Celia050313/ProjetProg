
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
            int prix = alea.Next(8,21);
        }

        public void ordonner() {
            // TODO implement here
        }

        public void assigneTable() {
            
        }

        public void groupe() {

            Random alea = new Random();
            int aleaFin = alea.Next(0, 19);
            int nbClient = 0;
            bool arrivee = false;
            int pourcentage = alea.Next(19);
            
            
            if (arrivee == true)
            {
                if (aleaFin <= 4)
                {
                    nbClient = 2;
                }

                else if (4 < aleaFin && aleaFin <= 10)
                {
                    nbClient = 4;
                }

                else if (10 < aleaFin && aleaFin <= 13)
                {
                    nbClient = 3;
                }

                else if (13 < aleaFin && aleaFin <= 16)
                {
                    nbClient = 6;
                }

                else nbClient = 10;


            }
            else nbClient = 0;
            Console.WriteLine(value: nbClient);
        }
    }

    public void ordre()
    {
        // TODO implement here
    }

    public void wait()
    {
        bool statut = true;
    }

    public void reserver()
    {
        bool reservation;
        Random alea = new Random();
        int aleaRnd = alea.Next(0, 5);
        if (aleaRnd <= 3)
        {
            reservation = false;
        }
        else reservation = true;
        Console.WriteLine(reservation);
    }

}
}