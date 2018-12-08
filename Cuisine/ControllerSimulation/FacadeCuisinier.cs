
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControllerSimulation{
    public class FacadeCuisinier {


        private Plongeur plongeur;
        private Cuisinier cuisinier;
        private Commis commis;
        private chefDeCuisine chefCuisine;

        public FacadeCuisinier() {

            plongeur = new Plongeur();
            cuisinier = new Cuisinier();
            commis = new Commis();
            chefCuisine = new chefDeCuisine();
        }



        public void Cuisinier() {
            // TODO implement here
        }

        public void Commis() {
            // TODO implement here
        }

        public void Stock() {
            // TODO implement here
        }

        public void Client() {
            // TODO implement here
        }

        public void Scenarii() {


            // TODO implement here
        }

        public void Plongeur() {


            // TODO implement here
        }

        public void chefDeCuisine() {
            // TODO implement here
        }

    }
}