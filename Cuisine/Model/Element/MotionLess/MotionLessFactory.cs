
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Element.Motionless{
    public class MotionLessFactory {

        public MotionLessFactory() {
        }



        /// <summary>
        /// @return
        /// </summary>
        public MotionLessElement createComptoire() {
            // TODO implement here
            return null;
        }
        public Element FactoryMethod(string motionless)
        {
            switch (motionless)
            {
                case "lavevaisselle":
                    return new LaveVaisselle();
                case "machinelaver":
                    return new MachineALaver();
                case "frigo":
                    return new Frigo();
                case "four":
                    return new Four();
                case "evier":
                    return new Evier();
                case "comptoircmd":
                    return new ComptoirCommande();
                default:
                    throw new System.Exception("Type de MachineCuisine non reconnu.");
            }
        }

        public void createChefDeCuisine() {
            // TODO implement here
        }

        public void createEvier() {
            // TODO implement here
        }

        public void createStock() {
            // TODO implement here
        }

        public void createComptoirCommande() {
            // TODO implement here
        }

        public void createLaveVaisselle() {
            // TODO implement here
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