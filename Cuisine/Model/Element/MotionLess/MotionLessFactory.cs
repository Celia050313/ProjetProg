
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Element.Motionless{
    public class MotionLessFactory {



        public MotionLessFactory() {
        }

        // instantiation of the motionless elements
        private static ChefDeCuisine chefDeCuisine = new ChefDeCuisine();
        private static ComptoirCommande comptoirCommande = new ComptoirCommande();
        private static ComptoirRetour comptoirRetour = new ComptoirRetour();
        private static Evier evier = new Evier();
        private static Stock stock = new Stock();




        public static MotionLessElements createComptoireRetour() {
            return comptoirRetour;
        }

        public static MotionLessElements createChefDeCuisine() {
            return chefDeCuisine;
        }

        public static MotionLessElements createEvier() {
            return evier;
        }

        public static MotionLessElements createStock() {
            return stock;
        }

        public static MotionLessElements createComptoirCommande() {
            return comptoirCommande;
        }

        /// <summary>
        /// @return
        /// </summary>
        public MotionLessElements getFile() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public Singleton getInstance() {
            // TODO implement here
            return null;
        }

    }
}