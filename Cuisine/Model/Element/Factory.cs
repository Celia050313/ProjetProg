
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Element{
    public class Factory {

        Singleton instance = new Singleton

        public Factory() {
        }

        // instantiation of the motionless elements
        private static ChefDeCuisine chefDeCuisine = new ChefDeCuisine();
        private static Commis commis = new Commis();
        private static Cuisinier cuisinier = new Cuisinier();
        private static Plongeur plongeur = new Plongeur();

        private static Element[] Elements =
        {
            chefDeCuisine,
            commis,
            cuisinier,
            plongeur};


        public static Element createChefDeCuisine() {
            return chefDeCuisine;
        }

        public static Element createCommis()
        {
            return commis;
        }
 
        public static Element createCuisinier()
        {
            return cuisinier;
        }
  
        public static Element createPlongeur()
        {
            return plongeur;
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