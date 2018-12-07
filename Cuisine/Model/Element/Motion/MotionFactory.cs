
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Element.Motion{
    public class MotionFactory {

        // instantiation of the motionless elements
        private static Assiette assiette = new Assiette();
        private static Casserole casserole = new Casserole();
        private static Commis commis = new Commis();
        private static Corbeille corbeille = new Corbeille();
        private static Couverts couverts = new Couverts();
        private static Cuisinier cuisinier = new Cuisinier();
        private static Nappe nappe = new Nappe();
        private static Plongeur plongeur = new Plongeur();
        private static Serviette serviette = new Serviette();
        private static Ustensil ustensil = new Ustensil();
        private static Verre verre = new Verre();

        private static MotionElement[] motionElements =
        {
            assiette,
            casserole,
            commis,
            corbeille,
            couverts,
            cuisinier,
            nappe,
            plongeur,
            serviette,
            ustensil,
            verre };

        public void Move() {
            // TODO implement here
        }

        public void setHasMoved() {
            // TODO implement here
        }

        public void getX() {
            // TODO implement here
        }

        public void setX() {
            // TODO implement here
        }

        public void setY() {
            // TODO implement here
        }

        public void getY() {
            // TODO implement here
        }


        public static MotionElement createAssiette()
        {
            return assiette;
        }
        
        public static MotionElement createCasserole()
        {
            return casserole;
        }

        public static MotionElement createCommis()
        {
            return commis;
        }
        public static MotionElement createCorbeille()
        {
            return corbeille;
        }
        public static MotionElement createCouverts()
        {
            return couverts;
        }
        public static MotionElement createCuisinier()
        {
            return cuisinier;
        }
        public static MotionElement createNappe()
        {
            return nappe;
        }
        public static MotionElement createPlongeur()
        {
            return plongeur;
        }
        public static MotionElement createServiette()
        {
            return serviette;
        }
                          
        public static MotionElement createUstensil() {
            return ustensil;
        }
                     
        public static MotionElement createVerre() {
            return verre;
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